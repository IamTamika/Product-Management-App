using ProductMaintenance.Model;
using System;
using System.Windows.Forms;
// Name of the Application: Product Maintenance
// Author : Tamika Taylor
// Date: 2021-05-03
namespace ProductMaintenance
{
    public partial class frmAddModifyProduct : Form
    {
        // these public properties are set by the main form
        public Products Product { get; set; } // selected product on the main form

        public bool AddProduct { get; set; } // flag that distinguishes Add from Modify

        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (AddProduct) // this is Add
            {
                this.Text = "Add Product";
                txtProductCode.ReadOnly = false;  // allow entry of new product code
            }
            else // this is Modify
            {
                this.Text = "Modify Product";
                txtProductCode.ReadOnly = true;   // can't change existing product code
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtProductCode.Text = Product.ProductCode;
            txtName.Text = Product.Name;
            txtVersion.Text = Product.Version.ToString();
            dtpReleaseDate.Value = Product.ReleaseDate;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
           
            if (IsValidData()) { 

                if (AddProduct) // this is Add
                {
                    // initialize the Product property with new Products object
                    this.Product = new Products();
                }
                this.LoadProductData(); // we have an object (public property Product) with new data
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            //is present
            errorMessage += Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtVersion.Text, txtVersion.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtVersion.Text, txtVersion.Tag.ToString());
          

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadProductData()
        {
            Product.ProductCode = txtProductCode.Text;
            Product.Name = txtName.Text;
            Product.Version = Convert.ToDecimal(txtVersion.Text);
            Product.ReleaseDate =  dtpReleaseDate.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtVersion.Clear();
            
        }
    }
}