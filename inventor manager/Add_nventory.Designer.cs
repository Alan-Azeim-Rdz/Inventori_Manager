namespace inventor_manager
{
    partial class Add_nventory
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
            BtnAdd = new Button();
            TxtAddName = new TextBox();
            LblName = new Label();
            LstViewDataProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            Price = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            TxtPrice = new TextBox();
            label2 = new Label();
            TxtQuanity = new TextBox();
            label3 = new Label();
            TxtMark = new TextBox();
            PicturUser = new PictureBox();
            BtnHome = new Button();
            BtnQuantityProductTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturUser).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(329, 171);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(89, 33);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnSearch_Click;
            // 
            // TxtAddName
            // 
            TxtAddName.Location = new Point(161, 71);
            TxtAddName.Name = "TxtAddName";
            TxtAddName.Size = new Size(133, 23);
            TxtAddName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(19, 71);
            LblName.Name = "LblName";
            LblName.Size = new Size(125, 15);
            LblName.TabIndex = 2;
            LblName.Text = "Name of the producto";
            // 
            // LstViewDataProductos
            // 
            LstViewDataProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, Price, columnHeader2, columnHeader3 });
            LstViewDataProductos.Location = new Point(640, 12);
            LstViewDataProductos.Name = "LstViewDataProductos";
            LstViewDataProductos.Size = new Size(505, 486);
            LstViewDataProductos.TabIndex = 3;
            LstViewDataProductos.UseCompatibleStateImageBehavior = false;
            LstViewDataProductos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 120;
            // 
            // Price
            // 
            Price.Tag = "";
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Available quantity";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mark";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 108);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 5;
            label1.Text = "Price of the producto";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(161, 108);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(133, 23);
            TxtPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 142);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Quantity";
            // 
            // TxtQuanity
            // 
            TxtQuanity.Location = new Point(161, 142);
            TxtQuanity.Name = "TxtQuanity";
            TxtQuanity.Size = new Size(133, 23);
            TxtQuanity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 180);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Mark";
            // 
            // TxtMark
            // 
            TxtMark.Location = new Point(161, 180);
            TxtMark.Name = "TxtMark";
            TxtMark.Size = new Size(133, 23);
            TxtMark.TabIndex = 8;
            // 
            // PicturUser
            // 
            PicturUser.Location = new Point(21, 12);
            PicturUser.Name = "PicturUser";
            PicturUser.Size = new Size(53, 50);
            PicturUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturUser.TabIndex = 10;
            PicturUser.TabStop = false;
            // 
            // BtnHome
            // 
            BtnHome.Location = new Point(12, 510);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(75, 23);
            BtnHome.TabIndex = 11;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnQuantityProductTotal
            // 
            BtnQuantityProductTotal.Location = new Point(439, 465);
            BtnQuantityProductTotal.Name = "BtnQuantityProductTotal";
            BtnQuantityProductTotal.Size = new Size(195, 33);
            BtnQuantityProductTotal.TabIndex = 12;
            BtnQuantityProductTotal.Text = "Quantity of te products total";
            BtnQuantityProductTotal.UseVisualStyleBackColor = true;
            BtnQuantityProductTotal.Click += BtnQuantityProductTotal_Click;
            // 
            // Add_nventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 545);
            Controls.Add(BtnQuantityProductTotal);
            Controls.Add(BtnHome);
            Controls.Add(PicturUser);
            Controls.Add(label3);
            Controls.Add(TxtMark);
            Controls.Add(label2);
            Controls.Add(TxtQuanity);
            Controls.Add(label1);
            Controls.Add(TxtPrice);
            Controls.Add(LstViewDataProductos);
            Controls.Add(LblName);
            Controls.Add(TxtAddName);
            Controls.Add(BtnAdd);
            Name = "Add_nventory";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PicturUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private TextBox TxtAddName;
        private Label LblName;
        private ListView LstViewDataProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader Price;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private TextBox TxtPrice;
        private Label label2;
        private TextBox TxtQuanity;
        private Label label3;
        private TextBox TxtMark;
        private PictureBox PicturUser;
        private Button BtnHome;
        private Button BtnQuantityProductTotal;
    }
}
