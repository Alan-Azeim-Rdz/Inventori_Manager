namespace inventor_manager
{
    partial class Form1
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
            BtnSearch = new Button();
            TxtSearchName = new TextBox();
            LblName = new Label();
            LstViewDataProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            Price = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(294, 12);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(89, 33);
            BtnSearch.TabIndex = 0;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtSearchName
            // 
            TxtSearchName.Location = new Point(153, 18);
            TxtSearchName.Name = "TxtSearchName";
            TxtSearchName.Size = new Size(133, 23);
            TxtSearchName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(22, 21);
            LblName.Name = "LblName";
            LblName.Size = new Size(125, 15);
            LblName.TabIndex = 2;
            LblName.Text = "Name of the producto";
            // 
            // LstViewDataProductos
            // 
            LstViewDataProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, Price, columnHeader2, columnHeader3 });
            LstViewDataProductos.Location = new Point(660, 12);
            LstViewDataProductos.Name = "LstViewDataProductos";
            LstViewDataProductos.Size = new Size(485, 486);
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
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 120;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 545);
            Controls.Add(LstViewDataProductos);
            Controls.Add(LblName);
            Controls.Add(TxtSearchName);
            Controls.Add(BtnSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearch;
        private TextBox TxtSearchName;
        private Label LblName;
        private ListView LstViewDataProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader Price;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
