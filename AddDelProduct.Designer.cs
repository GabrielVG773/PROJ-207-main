namespace PROJ_207_Project_2
{
    partial class AddDelProduct
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
            btnOk = new Button();
            btnCancel = new Button();
            cboProduct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtCurrentSupplier = new TextBox();
            label3 = new Label();
            txtCurrentSupplierID = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(53, 195);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(107, 38);
            btnOk.TabIndex = 0;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 195);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(186, 123);
            cboProduct.Margin = new Padding(4, 5, 4, 5);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(218, 33);
            cboProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 3;
            label1.Text = "Product: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "Current  Supplier: ";
            // 
            // txtCurrentSupplier
            // 
            txtCurrentSupplier.Location = new Point(186, 75);
            txtCurrentSupplier.Margin = new Padding(4, 5, 4, 5);
            txtCurrentSupplier.Name = "txtCurrentSupplier";
            txtCurrentSupplier.Size = new Size(218, 31);
            txtCurrentSupplier.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 6;
            label3.Text = "Current Supplier ID: ";
            // 
            // txtCurrentSupplierID
            // 
            txtCurrentSupplierID.Location = new Point(186, 27);
            txtCurrentSupplierID.Margin = new Padding(4, 5, 4, 5);
            txtCurrentSupplierID.Name = "txtCurrentSupplierID";
            txtCurrentSupplierID.Size = new Size(108, 31);
            txtCurrentSupplierID.TabIndex = 7;
            // 
            // AddDelProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 278);
            Controls.Add(txtCurrentSupplierID);
            Controls.Add(label3);
            Controls.Add(txtCurrentSupplier);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboProduct);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddDelProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDelProduct";
            Load += AddDelProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private ComboBox cboProduct;
        private Label label1;
        private Label label2;
        private TextBox txtCurrentSupplier;
        private Label label3;
        private TextBox txtCurrentSupplierID;
    }
}