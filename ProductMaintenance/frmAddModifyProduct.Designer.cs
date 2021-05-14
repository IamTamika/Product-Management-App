
namespace ProductMaintenance
{
    partial class frmAddModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(384, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(97, 359);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(200, 50);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductCode.Location = new System.Drawing.Point(312, 102);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(272, 27);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.Tag = "Product Code";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(312, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVersion.Location = new System.Drawing.Point(312, 219);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(272, 27);
            this.txtVersion.TabIndex = 2;
            this.txtVersion.Tag = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Release Date";
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReleaseDate.Location = new System.Drawing.Point(312, 273);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(272, 27);
            this.dtpReleaseDate.TabIndex = 3;
            this.dtpReleaseDate.Tag = "Release Date";
            // 
            // frmAddModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(682, 503);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmAddModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddModifyProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
    }
}