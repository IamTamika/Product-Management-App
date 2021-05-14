using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProductMaintenance.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Name of the Application: Product Maintenance
// Author :Tamika Taylor
// Date: 2021-05-03

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private TechSupportContext context = new TechSupportContext();
        private Products selectedProduct;

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            dgvProducts.Columns.Clear();
            var products = context.Products // retrieve products data
                .OrderBy(p => p.Name) // ordered alpabetically by description
                .Select(p => new { p.ProductCode, p.Name, p.Version, p.ReleaseDate }) // only four columns
                .ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            { // object initializer
                UseColumnTextForButtonValue = true,
                HeaderText = "", // header on the top
                Text = "Modify"
            };

            dgvProducts.Columns.Add(modifyColumn);// add new column to the grid view

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteColumn);

            // format the column header
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // black background on headers
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // white text on headers

            // format the odd numbered rows
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew; //light green alternate rows 

            // format the first column
            dgvProducts.Columns[0].HeaderText = "Product Code";
            dgvProducts.Columns[0].Width = 125;

            // format the second column
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[1].Width = 330;

            // format the third column
            dgvProducts.Columns[2].HeaderText = "Version";
            dgvProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[2].Width = 100;
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the fourth column
            dgvProducts.Columns[3].HeaderText = "Release Date";
            dgvProducts.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[3].Width = 100;
            dgvProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[3].DefaultCellStyle.Format = "d";

            dgvProducts.Columns[4].Width = 130;
            dgvProducts.Columns[5].Width = 130;
           
            
           
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e object carries information about the click
            // like e.ColumnIndex and e.RowIndex
            {
                // store index values for Modify and Delete button columns
                const int ModifyIndex = 4; // Modify buttins are column 4
                const int DeleteIndex = 5; // Delete buttons are column 5

                if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex) // is it a button?
                {
                    // get the product code:
                    // grid view has properties (collection) Rows and Columns
                    // product code is cell number 0 in the current row
                    // need to trim white spaces from char(10) column
                    string productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    selectedProduct = context.Products.Find(productCode);// find by PK value
                }

                if (e.ColumnIndex == ModifyIndex) // user clicked on Modify
                {
                    ModifyProduct();
                }
                else if (e.ColumnIndex == DeleteIndex) // user clicked on Delete
                {
                    DeleteProduct();
                }
            }
        }

        private void DeleteProduct()
        {
            DialogResult result =
               MessageBox.Show($"Delete {selectedProduct.ProductCode.Trim()}?",
               "Confirm Delete", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)// user confirmed
            {
                try
                {
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges(true);
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplayProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddProduct = true
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)// user clicked on Accept on the second form
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;// record product from the second
                                                                   // form as the current product
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void ModifyProduct()
        {
            var addModifyProductForm = new frmAddModifyProduct()
            { // object initializer
                AddProduct = false,
                Product = selectedProduct
            };
            DialogResult result = addModifyProductForm.ShowDialog();// display modal
            if (result == DialogResult.OK)// user clicked Accept on the second form
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product; // new data
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        
    }
}