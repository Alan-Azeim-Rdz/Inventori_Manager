using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace inventor_manager
{
    public partial class Inicio : Form
    {

        int i = 0;
        string url_data_employee = "C:\\Users\\1gren\\Documents\\archivos_R\\Cuentas_Nombres.txt";
        public Inicio()
        {
            InitializeComponent();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (File.Exists(url_data_employee))
            {
                string[] Data = File.ReadAllLines(url_data_employee);

                string Information_login = TxtEmail.Text + " " + TxtPasword.Text;
                for (int i = 0; i < Data.Length; i++)
                {
                    if (Data[i] == Information_login)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        break;
                    }
                    if (i == Data.Length - 1)
                    {
                        MessageBox.Show("El correo o la contraseña no existen, porfavor revicelo");
                        break;
                    }
                }



            }
            else
            {
                MessageBox.Show("El texto no se encontró en el archivo.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Images = new OpenFileDialog();
            Images.Filter = "Image Files|*.jpg";
            Images.Title = "Select a Image File";

            //if the user select a file, set the path to the textbox
            if (Images.ShowDialog() != DialogResult.OK)
            {
                return;  // User canceled the file selection dialog
            }

            try
            {
                // Load the image using a try-catch block for error handling
                PicturEmplayPhoto.Image = Image.FromFile(Images.FileName);
            }
            catch (Exception ex)
            {
                // Handle potential exceptions like invalid file format or path issues
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string Information_login = TxtEmail.Text + " " + TxtPasword.Text;



        }
    }
}
