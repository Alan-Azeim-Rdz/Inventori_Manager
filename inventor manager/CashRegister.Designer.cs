namespace inventor_manager
{
    partial class CashRegister
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
            PictureUser = new PictureBox();
            LstViewDataProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            Price = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            LblSelection = new Label();
            BtnSelection = new Button();
            TxtQuantity = new TextBox();
            LblTotal = new Label();
            LblResult = new Label();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            LblTiket = new Label();
            BtnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
            // 
            // PictureUser
            // 
            PictureUser.Location = new Point(12, 12);
            PictureUser.Name = "PictureUser";
            PictureUser.Size = new Size(55, 54);
            PictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureUser.TabIndex = 0;
            PictureUser.TabStop = false;
            // 
            // LstViewDataProductos
            // 
            LstViewDataProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, Price, columnHeader2, columnHeader3 });
            LstViewDataProductos.Location = new Point(595, 12);
            LstViewDataProductos.Name = "LstViewDataProductos";
            LstViewDataProductos.Size = new Size(505, 486);
            LstViewDataProductos.TabIndex = 4;
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
            // LblSelection
            // 
            LblSelection.AutoSize = true;
            LblSelection.Location = new Point(258, 80);
            LblSelection.Name = "LblSelection";
            LblSelection.Size = new Size(55, 15);
            LblSelection.TabIndex = 5;
            LblSelection.Text = "Selection";
            // 
            // BtnSelection
            // 
            BtnSelection.Location = new Point(285, 173);
            BtnSelection.Name = "BtnSelection";
            BtnSelection.Size = new Size(75, 23);
            BtnSelection.TabIndex = 6;
            BtnSelection.Text = "Select";
            BtnSelection.UseVisualStyleBackColor = true;
            BtnSelection.Click += BtnSelection_Click;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Location = new Point(209, 117);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(151, 23);
            TxtQuantity.TabIndex = 7;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Rockwell", 15F);
            LblTotal.Location = new Point(85, 529);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(131, 22);
            LblTotal.TabIndex = 8;
            LblTotal.Text = "total payable";
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("Segoe UI", 15F);
            LblResult.Location = new Point(308, 524);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(0, 28);
            LblResult.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(29, 269);
            listView1.Name = "listView1";
            listView1.Size = new Size(505, 229);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Tag = "";
            columnHeader5.Text = "Price";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Available quantity";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Mark";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 120;
            // 
            // LblTiket
            // 
            LblTiket.AutoSize = true;
            LblTiket.Location = new Point(29, 251);
            LblTiket.Name = "LblTiket";
            LblTiket.Size = new Size(32, 15);
            LblTiket.TabIndex = 11;
            LblTiket.Text = "Tiket";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(204, 173);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 12;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += this.BtnAdd_Click;
            // 
            // CashRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 577);
            Controls.Add(BtnAdd);
            Controls.Add(LblTiket);
            Controls.Add(listView1);
            Controls.Add(LblResult);
            Controls.Add(LblTotal);
            Controls.Add(TxtQuantity);
            Controls.Add(BtnSelection);
            Controls.Add(LblSelection);
            Controls.Add(LstViewDataProductos);
            Controls.Add(PictureUser);
            Name = "CashRegister";
            Text = "cash register";
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureUser;
        private ListView LstViewDataProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader Price;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label LblSelection;
        private Button BtnSelection;
        private TextBox TxtQuantity;
        private Label LblTotal;
        private Label LblResult;
        private ListView listView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label LblTiket;
        private Button BtnAdd;
    }
}