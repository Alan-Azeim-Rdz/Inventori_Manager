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
            ColName = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            expirationdate = new ColumnHeader();
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
            CheckBoxPerecedero = new CheckBox();
            DataTimeExpirationDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
            // 
            // ListViewDataProduct
            // 
            ListViewDataProduct.Columns.AddRange(new ColumnHeader[] { ColName, columnHeader1, columnHeader2, columnHeader3, expirationdate });
            ListViewDataProduct.Location = new Point(14, 16);
            ListViewDataProduct.Margin = new Padding(3, 4, 3, 4);
            ListViewDataProduct.Name = "ListViewDataProduct";
            ListViewDataProduct.Size = new Size(699, 615);
            ListViewDataProduct.TabIndex = 1;
            ListViewDataProduct.UseCompatibleStateImageBehavior = false;
            ListViewDataProduct.View = View.Details;
            ListViewDataProduct.SelectedIndexChanged += ListViewDataProduct_SelectedIndexChanged;
            // 
            // ColName
            // 
            ColName.Text = "Name";
            ColName.Width = 120;
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
            // expirationdate
            // 
            expirationdate.Text = "expiration date";
            expirationdate.Width = 140;
            // 
            // PictureUser
            // 
            PictureUser.Location = new Point(1384, 16);
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
            label3.Location = new Point(805, 193);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 18;
            label3.Text = "Mark";
            // 
            // TxtMark
            // 
            TxtMark.Location = new Point(967, 193);
            TxtMark.Margin = new Padding(3, 4, 3, 4);
            TxtMark.Name = "TxtMark";
            TxtMark.Size = new Size(151, 27);
            TxtMark.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(805, 143);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 16;
            label2.Text = "Quantity";
            // 
            // TxtQuanity
            // 
            TxtQuanity.Location = new Point(967, 143);
            TxtQuanity.Margin = new Padding(3, 4, 3, 4);
            TxtQuanity.Name = "TxtQuanity";
            TxtQuanity.Size = new Size(151, 27);
            TxtQuanity.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(805, 97);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 14;
            label1.Text = "Price of the producto";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(967, 97);
            TxtPrice.Margin = new Padding(3, 4, 3, 4);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(151, 27);
            TxtPrice.TabIndex = 13;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(805, 48);
            LblName.Name = "LblName";
            LblName.Size = new Size(157, 20);
            LblName.TabIndex = 12;
            LblName.Text = "Name of the producto";
            // 
            // TxtAddName
            // 
            TxtAddName.Location = new Point(967, 48);
            TxtAddName.Margin = new Padding(3, 4, 3, 4);
            TxtAddName.Name = "TxtAddName";
            TxtAddName.Size = new Size(151, 27);
            TxtAddName.TabIndex = 11;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(1245, 251);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(102, 44);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Btnaccept
            // 
            Btnaccept.Location = new Point(1197, 183);
            Btnaccept.Margin = new Padding(3, 4, 3, 4);
            Btnaccept.Name = "Btnaccept";
            Btnaccept.Size = new Size(102, 49);
            Btnaccept.TabIndex = 21;
            Btnaccept.Text = "Accept";
            Btnaccept.UseVisualStyleBackColor = true;
            Btnaccept.Click += Btnaccept_Click;
            // 
            // ComBoxElection
            // 
            ComBoxElection.FormattingEnabled = true;
            ComBoxElection.Items.AddRange(new object[] { "Add", "Edit" });
            ComBoxElection.Location = new Point(1229, 119);
            ComBoxElection.Margin = new Padding(3, 4, 3, 4);
            ComBoxElection.Name = "ComBoxElection";
            ComBoxElection.Size = new Size(138, 28);
            ComBoxElection.TabIndex = 22;
            // 
            // BtnQuantityProductTotal
            // 
            BtnQuantityProductTotal.Location = new Point(752, 588);
            BtnQuantityProductTotal.Margin = new Padding(3, 4, 3, 4);
            BtnQuantityProductTotal.Name = "BtnQuantityProductTotal";
            BtnQuantityProductTotal.Size = new Size(223, 44);
            BtnQuantityProductTotal.TabIndex = 23;
            BtnQuantityProductTotal.Text = "Quantity of te products total";
            BtnQuantityProductTotal.UseVisualStyleBackColor = true;
            BtnQuantityProductTotal.Click += BtnQuantityProductTotal_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(1305, 185);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(102, 44);
            BtnCancel.TabIndex = 24;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // CheckBoxPerecedero
            // 
            CheckBoxPerecedero.AutoSize = true;
            CheckBoxPerecedero.Location = new Point(805, 251);
            CheckBoxPerecedero.Margin = new Padding(3, 4, 3, 4);
            CheckBoxPerecedero.Name = "CheckBoxPerecedero";
            CheckBoxPerecedero.Size = new Size(105, 24);
            CheckBoxPerecedero.TabIndex = 25;
            CheckBoxPerecedero.Text = "Perecedero";
            CheckBoxPerecedero.UseVisualStyleBackColor = true;
            // 
            // DataTimeExpirationDate
            // 
            DataTimeExpirationDate.CustomFormat = "";
            DataTimeExpirationDate.Format = DateTimePickerFormat.Short;
            DataTimeExpirationDate.Location = new Point(936, 251);
            DataTimeExpirationDate.Name = "DataTimeExpirationDate";
            DataTimeExpirationDate.Size = new Size(149, 27);
            DataTimeExpirationDate.TabIndex = 27;
            DataTimeExpirationDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Edit_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 671);
            Controls.Add(DataTimeExpirationDate);
            Controls.Add(CheckBoxPerecedero);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Edit_Inventory";
            Text = "Products_sold";
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ListViewDataProduct;
        private ColumnHeader ColName;
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
        private CheckBox CheckBoxPerecedero;
        private ColumnHeader expirationdate;
        private DateTimePicker DataTimeExpirationDate;
    }
}