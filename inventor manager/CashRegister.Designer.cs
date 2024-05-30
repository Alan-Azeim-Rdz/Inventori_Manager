﻿namespace inventor_manager
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
            ListVTicket = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            LblTiket = new Label();
            BtnAdd = new Button();
            BtnTicketJason = new Button();
            BtnTicketExcel = new Button();
            BtnPdfTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            SuspendLayout();
            // 
            // PictureUser
            // 
            PictureUser.Location = new Point(14, 16);
            PictureUser.Margin = new Padding(3, 4, 3, 4);
            PictureUser.Name = "PictureUser";
            PictureUser.Size = new Size(63, 72);
            PictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureUser.TabIndex = 0;
            PictureUser.TabStop = false;
            // 
            // LstViewDataProductos
            // 
            LstViewDataProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, Price, columnHeader2, columnHeader3 });
            LstViewDataProductos.Location = new Point(680, 16);
            LstViewDataProductos.Margin = new Padding(3, 4, 3, 4);
            LstViewDataProductos.Name = "LstViewDataProductos";
            LstViewDataProductos.Size = new Size(577, 647);
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
            LblSelection.Font = new Font("Segoe UI Black", 9F);
            LblSelection.Location = new Point(129, 84);
            LblSelection.Name = "LblSelection";
            LblSelection.Size = new Size(384, 47);
            LblSelection.TabIndex = 5;
            LblSelection.Text = "Selection";
            LblSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSelection
            // 
            BtnSelection.Location = new Point(326, 231);
            BtnSelection.Margin = new Padding(3, 4, 3, 4);
            BtnSelection.Name = "BtnSelection";
            BtnSelection.Size = new Size(86, 31);
            BtnSelection.TabIndex = 6;
            BtnSelection.Text = "Select";
            BtnSelection.UseVisualStyleBackColor = true;
            BtnSelection.Click += BtnSelection_Click;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Location = new Point(239, 156);
            TxtQuantity.Margin = new Padding(3, 4, 3, 4);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(172, 27);
            TxtQuantity.TabIndex = 7;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Rockwell", 15F);
            LblTotal.Location = new Point(97, 705);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(162, 29);
            LblTotal.TabIndex = 8;
            LblTotal.Text = "total payable";
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("Segoe UI", 15F);
            LblResult.Location = new Point(352, 699);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(0, 35);
            LblResult.TabIndex = 9;
            // 
            // ListVTicket
            // 
            ListVTicket.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            ListVTicket.Location = new Point(33, 359);
            ListVTicket.Margin = new Padding(3, 4, 3, 4);
            ListVTicket.Name = "ListVTicket";
            ListVTicket.Size = new Size(577, 304);
            ListVTicket.TabIndex = 10;
            ListVTicket.UseCompatibleStateImageBehavior = false;
            ListVTicket.View = View.Details;
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
            LblTiket.Location = new Point(33, 335);
            LblTiket.Name = "LblTiket";
            LblTiket.Size = new Size(41, 20);
            LblTiket.TabIndex = 11;
            LblTiket.Text = "Tiket";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(233, 231);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(86, 31);
            BtnAdd.TabIndex = 12;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnTicketJason
            // 
            BtnTicketJason.Location = new Point(747, 688);
            BtnTicketJason.Margin = new Padding(3, 4, 3, 4);
            BtnTicketJason.Name = "BtnTicketJason";
            BtnTicketJason.Size = new Size(118, 63);
            BtnTicketJason.TabIndex = 13;
            BtnTicketJason.Text = "Print Ticket";
            BtnTicketJason.UseVisualStyleBackColor = true;
            BtnTicketJason.Click += BtnTicketJason_Click;
            // 
            // BtnTicketExcel
            // 
            BtnTicketExcel.Location = new Point(884, 688);
            BtnTicketExcel.Margin = new Padding(3, 4, 3, 4);
            BtnTicketExcel.Name = "BtnTicketExcel";
            BtnTicketExcel.Size = new Size(133, 63);
            BtnTicketExcel.TabIndex = 14;
            BtnTicketExcel.Text = "Print Ticket (excel)";
            BtnTicketExcel.UseVisualStyleBackColor = true;
            BtnTicketExcel.Click += BtnTicketExcel_Click;
            // 
            // BtnPdfTicket
            // 
            BtnPdfTicket.Location = new Point(1033, 690);
            BtnPdfTicket.Margin = new Padding(3, 4, 3, 4);
            BtnPdfTicket.Name = "BtnPdfTicket";
            BtnPdfTicket.Size = new Size(133, 63);
            BtnPdfTicket.TabIndex = 15;
            BtnPdfTicket.Text = "Print Ticket (Pdf)";
            BtnPdfTicket.UseVisualStyleBackColor = true;
            BtnPdfTicket.Click += BtnPdfTicket_Click;
            // 
            // CashRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 769);
            Controls.Add(BtnPdfTicket);
            Controls.Add(BtnTicketExcel);
            Controls.Add(BtnTicketJason);
            Controls.Add(BtnAdd);
            Controls.Add(LblTiket);
            Controls.Add(ListVTicket);
            Controls.Add(LblResult);
            Controls.Add(LblTotal);
            Controls.Add(TxtQuantity);
            Controls.Add(BtnSelection);
            Controls.Add(LblSelection);
            Controls.Add(LstViewDataProductos);
            Controls.Add(PictureUser);
            Margin = new Padding(3, 4, 3, 4);
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
        private ListView ListVTicket;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label LblTiket;
        private Button BtnAdd;
        private Button BtnTicketJason;
        private Button BtnTicketExcel;
        private Button BtnPdfTicket;
    }
}