namespace inventor_manager
{
    partial class Inicio
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
            BtnLogin = new Button();
            LblPasword = new Label();
            LblEmail = new Label();
            TxtPasword = new TextBox();
            TxtEmail = new TextBox();
            PicturEmplayPhoto = new PictureBox();
            BtnRegister = new Button();
            BtnUploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturEmplayPhoto).BeginInit();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(245, 202);
            BtnLogin.Margin = new Padding(3, 2, 3, 2);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(82, 22);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LblPasword
            // 
            LblPasword.AutoSize = true;
            LblPasword.Location = new Point(161, 137);
            LblPasword.Name = "LblPasword";
            LblPasword.Size = new Size(52, 15);
            LblPasword.TabIndex = 1;
            LblPasword.Text = "Pasword";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(161, 94);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "Email";
            // 
            // TxtPasword
            // 
            TxtPasword.Location = new Point(245, 135);
            TxtPasword.Margin = new Padding(3, 2, 3, 2);
            TxtPasword.Name = "TxtPasword";
            TxtPasword.Size = new Size(213, 23);
            TxtPasword.TabIndex = 3;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(245, 92);
            TxtEmail.Margin = new Padding(3, 2, 3, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(213, 23);
            TxtEmail.TabIndex = 4;
            // 
            // PicturEmplayPhoto
            // 
            PicturEmplayPhoto.AccessibleRole = AccessibleRole.Cursor;
            PicturEmplayPhoto.BackColor = Color.Cyan;
            PicturEmplayPhoto.Image = Properties.Resources._6073873;
            PicturEmplayPhoto.Location = new Point(535, 32);
            PicturEmplayPhoto.Margin = new Padding(3, 2, 3, 2);
            PicturEmplayPhoto.Name = "PicturEmplayPhoto";
            PicturEmplayPhoto.Size = new Size(203, 192);
            PicturEmplayPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicturEmplayPhoto.TabIndex = 5;
            PicturEmplayPhoto.TabStop = false;
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(375, 202);
            BtnRegister.Margin = new Padding(3, 2, 3, 2);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(82, 22);
            BtnRegister.TabIndex = 6;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnUploadImage
            // 
            BtnUploadImage.Location = new Point(570, 243);
            BtnUploadImage.Margin = new Padding(3, 2, 3, 2);
            BtnUploadImage.Name = "BtnUploadImage";
            BtnUploadImage.Size = new Size(140, 22);
            BtnUploadImage.TabIndex = 7;
            BtnUploadImage.Text = "upload image";
            BtnUploadImage.UseVisualStyleBackColor = true;
            BtnUploadImage.Click += BtnUploadImage_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 294);
            Controls.Add(BtnUploadImage);
            Controls.Add(BtnRegister);
            Controls.Add(PicturEmplayPhoto);
            Controls.Add(TxtEmail);
            Controls.Add(TxtPasword);
            Controls.Add(LblEmail);
            Controls.Add(LblPasword);
            Controls.Add(BtnLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)PicturEmplayPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label LblPasword;
        private Label LblEmail;
        private TextBox TxtPasword;
        private TextBox TxtEmail;
        private Button BtnRegister;
        public PictureBox PicturEmplayPhoto;
        private Button BtnUploadImage;
    }
}