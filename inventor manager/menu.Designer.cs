namespace inventor_manager
{
    partial class menu
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
            BtnInventory = new Button();
            BtnSouldProduct = new Button();
            PictureImagePhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureImagePhoto).BeginInit();
            SuspendLayout();
            // 
            // BtnInventory
            // 
            BtnInventory.Location = new Point(12, 139);
            BtnInventory.Name = "BtnInventory";
            BtnInventory.Size = new Size(358, 139);
            BtnInventory.TabIndex = 0;
            BtnInventory.Text = "Add Inventory";
            BtnInventory.UseVisualStyleBackColor = true;
            BtnInventory.Click += BtnInventory_Click;
            // 
            // BtnSouldProduct
            // 
            BtnSouldProduct.Location = new Point(430, 139);
            BtnSouldProduct.Name = "BtnSouldProduct";
            BtnSouldProduct.Size = new Size(358, 139);
            BtnSouldProduct.TabIndex = 1;
            BtnSouldProduct.Text = "Sold Product";
            BtnSouldProduct.UseVisualStyleBackColor = true;
            BtnSouldProduct.Click += BtnSouldProduct_Click;
            // 
            // PictureImagePhoto
            // 
            PictureImagePhoto.Location = new Point(12, 12);
            PictureImagePhoto.Name = "PictureImagePhoto";
            PictureImagePhoto.Size = new Size(68, 64);
            PictureImagePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureImagePhoto.TabIndex = 2;
            PictureImagePhoto.TabStop = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureImagePhoto);
            Controls.Add(BtnSouldProduct);
            Controls.Add(BtnInventory);
            Name = "menu";
            Text = "menu";
            ((System.ComponentModel.ISupportInitialize)PictureImagePhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnInventory;
        private Button BtnSouldProduct;
        private PictureBox PictureImagePhoto;
    }
}