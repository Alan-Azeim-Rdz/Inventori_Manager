namespace inventor_manager
{
    partial class Products_sold
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
            BtnAccept = new Button();
            ListViewDataProduct = new ListView();
            Name = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            PictureUser = new PictureBox();
            label3 = new Label();
            TxtMark = new TextBox();
            label2 = new Label();
            TxtQuanity = new TextBox();
            label1 = new Label();
            TxtPrice = new TextBox();
            LblName = new Label();
            TxtAddName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
            // 
            // BtnAccept
            // 
            BtnAccept.Location = new Point(881, 127);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(89, 33);
            BtnAccept.TabIndex = 0;
            BtnAccept.Text = "accept";
            BtnAccept.UseVisualStyleBackColor = true;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // ListViewDataProduct
            // 
            ListViewDataProduct.Columns.AddRange(new ColumnHeader[] { Name, columnHeader1, columnHeader2, columnHeader3 });
            ListViewDataProduct.Location = new Point(12, 12);
            ListViewDataProduct.Name = "ListViewDataProduct";
            ListViewDataProduct.Size = new Size(485, 462);
            ListViewDataProduct.TabIndex = 1;
            ListViewDataProduct.UseCompatibleStateImageBehavior = false;
            ListViewDataProduct.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Price";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Available quantity";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mark";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // PictureUser
            // 
            PictureUser.Location = new Point(1056, 12);
            PictureUser.Name = "PictureUser";
            PictureUser.Size = new Size(55, 49);
            PictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureUser.TabIndex = 2;
            PictureUser.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 145);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 18;
            label3.Text = "Mark";
            // 
            // TxtMark
            // 
            TxtMark.Location = new Point(691, 145);
            TxtMark.Name = "TxtMark";
            TxtMark.Size = new Size(133, 23);
            TxtMark.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 107);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 16;
            label2.Text = "Quantity";
            // 
            // TxtQuanity
            // 
            TxtQuanity.Location = new Point(691, 107);
            TxtQuanity.Name = "TxtQuanity";
            TxtQuanity.Size = new Size(133, 23);
            TxtQuanity.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 73);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 14;
            label1.Text = "Price of the producto";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(691, 73);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(133, 23);
            TxtPrice.TabIndex = 13;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(549, 36);
            LblName.Name = "LblName";
            LblName.Size = new Size(125, 15);
            LblName.TabIndex = 12;
            LblName.Text = "Name of the producto";
            // 
            // TxtAddName
            // 
            TxtAddName.Location = new Point(691, 36);
            TxtAddName.Name = "TxtAddName";
            TxtAddName.Size = new Size(133, 23);
            TxtAddName.TabIndex = 11;
            // 
            // Products_sold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 503);
            Controls.Add(label3);
            Controls.Add(TxtMark);
            Controls.Add(label2);
            Controls.Add(TxtQuanity);
            Controls.Add(label1);
            Controls.Add(TxtPrice);
            Controls.Add(LblName);
            Controls.Add(TxtAddName);
            Controls.Add(PictureUser);
            Controls.Add(ListViewDataProduct);
            Controls.Add(BtnAccept);
            Text = "Products_sold";
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAccept;
        private ListView ListViewDataProduct;
        private ColumnHeader Name;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private PictureBox PictureUser;
        private Label label3;
        private TextBox TxtMark;
        private Label label2;
        private TextBox TxtQuanity;
        private Label label1;
        private TextBox TxtPrice;
        private Label LblName;
        private TextBox TxtAddName;
    }
}