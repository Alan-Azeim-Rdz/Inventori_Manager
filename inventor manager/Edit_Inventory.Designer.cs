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
            BtnDelete = new Button();
            Btnaccept = new Button();
            ComBoxElection = new ComboBox();
            BtnQuantityProductTotal = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
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
            ListViewDataProduct.SelectedIndexChanged += ListViewDataProduct_SelectedIndexChanged;
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
            // BtnDelete
            // 
            BtnDelete.Location = new Point(934, 188);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(89, 33);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Btnaccept
            // 
            Btnaccept.Location = new Point(892, 137);
            Btnaccept.Name = "Btnaccept";
            Btnaccept.Size = new Size(89, 37);
            Btnaccept.TabIndex = 21;
            Btnaccept.Text = "Accept";
            Btnaccept.UseVisualStyleBackColor = true;
            Btnaccept.Click += Btnaccept_Click;
            // 
            // ComBoxElection
            // 
            ComBoxElection.FormattingEnabled = true;
            ComBoxElection.Items.AddRange(new object[] { "Add", "Edit" });
            ComBoxElection.Location = new Point(916, 99);
            ComBoxElection.Name = "ComBoxElection";
            ComBoxElection.Size = new Size(121, 23);
            ComBoxElection.TabIndex = 22;
            // 
            // BtnQuantityProductTotal
            // 
            BtnQuantityProductTotal.Location = new Point(503, 441);
            BtnQuantityProductTotal.Name = "BtnQuantityProductTotal";
            BtnQuantityProductTotal.Size = new Size(195, 33);
            BtnQuantityProductTotal.TabIndex = 23;
            BtnQuantityProductTotal.Text = "Quantity of te products total";
            BtnQuantityProductTotal.UseVisualStyleBackColor = true;
            BtnQuantityProductTotal.Click += BtnQuantityProductTotal_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(987, 139);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(89, 33);
            BtnCancel.TabIndex = 24;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // Edit_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 503);
            Controls.Add(BtnCancel);
            Controls.Add(BtnQuantityProductTotal);
            Controls.Add(ComBoxElection);
            Controls.Add(Btnaccept);
            Controls.Add(BtnDelete);
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
            Text = "Products_sold";
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button BtnDelete;
        private Button Btnaccept;
        private ComboBox ComBoxElection;
        private Button BtnQuantityProductTotal;
        private Button BtnCancel;
    }
}