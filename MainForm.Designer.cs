namespace PROJ_207_Project_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            packagesButton = new Button();
            suppliersButton = new Button();
            productsButton = new Button();
            SuspendLayout();
            // 
            // packagesButton
            // 
            packagesButton.Location = new Point(165, 26);
            packagesButton.Margin = new Padding(4, 5, 4, 5);
            packagesButton.Name = "packagesButton";
            packagesButton.Size = new Size(107, 38);
            packagesButton.TabIndex = 0;
            packagesButton.Text = "Packages";
            packagesButton.UseVisualStyleBackColor = true;
            packagesButton.Click += packagesButton_Click;
            // 
            // suppliersButton
            // 
            suppliersButton.Location = new Point(165, 74);
            suppliersButton.Margin = new Padding(4, 5, 4, 5);
            suppliersButton.Name = "suppliersButton";
            suppliersButton.Size = new Size(107, 38);
            suppliersButton.TabIndex = 1;
            suppliersButton.Text = "Suppliers";
            suppliersButton.UseVisualStyleBackColor = true;
            suppliersButton.Click += suppliersButton_Click;
            // 
            // productsButton
            // 
            productsButton.Location = new Point(165, 122);
            productsButton.Margin = new Padding(4, 5, 4, 5);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(107, 38);
            productsButton.TabIndex = 2;
            productsButton.Text = "Products";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 204);
            Controls.Add(productsButton);
            Controls.Add(suppliersButton);
            Controls.Add(packagesButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Employee Data Management Tool";
            ResumeLayout(false);
        }

        #endregion

        private Button packagesButton;
        private Button suppliersButton;
        private Button productsButton;
    }
}