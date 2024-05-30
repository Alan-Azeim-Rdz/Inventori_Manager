namespace inventor_manager
{
    partial class Edit_Inventory
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
            BtnSeelct = new Button();
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
            BtnReplace = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
            // 
            // BtnSeelct
            // 
            BtnSeelct.Location = new Point(1056, 119);
            BtnSeelct.Margin = new Padding(3, 4, 3, 4);
            BtnSeelct.Name = "BtnSeelct";
            BtnSeelct.Size = new Size(102, 44);
            BtnSeelct.TabIndex = 0;
            BtnSeelct.Text = "Select";
            BtnSeelct.UseVisualStyleBackColor = true;
            BtnSeelct.Click += BtnSelect_Click;
            // 
            // ListViewDataProduct
            // 
            ListViewDataProduct.Columns.AddRange(new ColumnHeader[] { Name, columnHeader1, columnHeader2, columnHeader3 });
            ListViewDataProduct.Location = new Point(14, 16);
            ListViewDataProduct.Margin = new Padding(3, 4, 3, 4);
            ListViewDataProduct.Name = "ListViewDataProduct";
            ListViewDataProduct.Size = new Size(554, 615);
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
            columnHeader1.Tag = "";
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
            PictureUser.Location = new Point(1207, 16);
            PictureUser.Margin = new Padding(3, 4, 3, 4);
            PictureUser.Name = "PictureUser";
            PictureUser.Size = new Size(63, 65);
            PictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureUser.TabIndex = 2;
            PictureUser.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 193);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 18;
            label3.Text = "Mark";
            // 
            // TxtMark
            // 
            TxtMark.Location = new Point(790, 193);
            TxtMark.Margin = new Padding(3, 4, 3, 4);
            TxtMark.Name = "TxtMark";
            TxtMark.Size = new Size(151, 27);
            TxtMark.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 143);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 16;
            label2.Text = "Quantity";
            // 
            // TxtQuanity
            // 
            TxtQuanity.Location = new Point(790, 143);
            TxtQuanity.Margin = new Padding(3, 4, 3, 4);
            TxtQuanity.Name = "TxtQuanity";
            TxtQuanity.Size = new Size(151, 27);
            TxtQuanity.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 97);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 14;
            label1.Text = "Price of the producto";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(790, 97);
            TxtPrice.Margin = new Padding(3, 4, 3, 4);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(151, 27);
            TxtPrice.TabIndex = 13;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(627, 48);
            LblName.Name = "LblName";
            LblName.Size = new Size(157, 20);
            LblName.TabIndex = 12;
            LblName.Text = "Name of the producto";
            // 
            // TxtAddName
            // 
            TxtAddName.Location = new Point(790, 48);
            TxtAddName.Margin = new Padding(3, 4, 3, 4);
            TxtAddName.Name = "TxtAddName";
            TxtAddName.Size = new Size(151, 27);
            TxtAddName.TabIndex = 11;
            // 
            // BtnReplace
            // 
            BtnReplace.Location = new Point(1056, 180);
            BtnReplace.Margin = new Padding(3, 4, 3, 4);
            BtnReplace.Name = "BtnReplace";
            BtnReplace.Size = new Size(102, 44);
            BtnReplace.TabIndex = 19;
            BtnReplace.Text = "Replace ";
            BtnReplace.UseVisualStyleBackColor = true;
            BtnReplace.Click += BtnReplace_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(1056, 248);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(102, 44);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Edit_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 671);
            Controls.Add(BtnDelete);
            Controls.Add(BtnReplace);
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
            Controls.Add(BtnSeelct);
            Margin = new Padding(3, 4, 3, 4);
            Text = "Products_sold";
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSeelct;
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
        private Button BtnReplace;
        private Button BtnDelete;
    }
}