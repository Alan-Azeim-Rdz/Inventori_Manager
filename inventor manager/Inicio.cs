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
        string url_data_employee = "C:\\Users\\1gren\\Documents\\archivos_R\\Cuentas_Nombres.text";
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Data_Emply = File.ReadAllLines(url_data_employee);
                foreach (string Email in Data_Emply)
                {
                    while (Email == Data_Emply[1])
                    {
                        break;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
        }

        private void PicturEmplayPhoto_Click(object sender, EventArgs e)
        {
            
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
    }
}
