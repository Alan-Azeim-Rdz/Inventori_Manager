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
        string Photo = string.Empty;
        int i = 0;
        string url_data_employee = "C:\\Users\\1gren\\Documents\\archivos_R\\Cuentas_Nombres.txt";
        public Inicio()
        {
            InitializeComponent();
            Inicio.ShowWelcomeMessage();
            dateandtime();

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
                        menu menu = new menu();
                        menu.Show();
                        menu.ReceivedImage = PicturEmplayPhoto.Image;
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
                Photo = Images.FileName;
            }
            catch (Exception ex)
            {
                // Handle potential exceptions like invalid file format or path issues
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            string Information_login = TxtEmail.Text + " " + TxtPasword.Text;

            if (File.Exists(url_data_employee))
            {
                string[] Data = File.ReadAllLines(url_data_employee);

                for (int i = 0; i < Data.Length; i++)
                {
                    if (Data[i] == Information_login)
                    {
                         MessageBox.Show("El correo o la contraseña ya existen");
                        break;
                    }
                    if (i == Data.Length - 1)
                    {
                        try
                        {

                            // Escribe el texto en el archivo en la ruta predefinida
                            File.AppendAllText(url_data_employee, Information_login + Environment.NewLine);

                            // Notificación de éxito
                            MessageBox.Show("Datos guardados exitosamente " , "Information_login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                }

            }
            else
            {
                MessageBox.Show("El texto no se encontró en el archivo.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           


        }





        public static void ShowWelcomeMessage()
        {
            MessageBox.Show("¡Bienvenido al administrador de inventario!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void dateandtime()
        {
            MessageBox.Show("La fecha y hora actual es: " + DateTime.Now.ToString(), "Fecha y Hora", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
