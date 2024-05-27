using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventor_manager
{
    public partial class CashRegister : Form
        
    {
        int resultFinish = 0;
        string Url_txt_productos = "C:\\Users\\1gren\\Documents\\archivos_R\\datos.txt";
        public CashRegister()
        {
            InitializeComponent();
            Filllistview();
        }

        private Image receivedImage;
        public Image ReceivedImage
        {
            get { return receivedImage; }
            set
            {
                receivedImage = value;
                PictureUser.Image = receivedImage;
            }
        }

        private void Filllistview()
        {
            try
            {
                if (File.Exists(Url_txt_productos))
                {
                    // Leer todas las líneas del archivo
                    string[] lineas = File.ReadAllLines(Url_txt_productos);

                    // Agregar cada línea como un elemento al ListView
                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split(' ');

                        ListViewItem item = new ListViewItem(partes[0]);
                        for (int i = 1; i < partes.Length; i++)
                        {
                            item.SubItems.Add(partes[i]);
                        }

                        // Agregar el item al ListView
                        LstViewDataProductos.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe en la ruta especificada.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnSelection_Click(object sender, EventArgs e)
        {
            if (LstViewDataProductos.SelectedItems.Count > 0)
            {
                var selectedItem = LstViewDataProductos.SelectedItems[0];
                LblSelection.Text = selectedItem.Text;

            }
            else
            {
                MessageBox.Show("Seleccione un ítem para editar.");
            }

            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstViewDataProductos.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                var selectedItem = LstViewDataProductos.SelectedItems[0];



                int Price = Convert.ToInt32(selectedItem.SubItems[1].Text);
                int Quantity = Convert.ToInt32(selectedItem.SubItems[2].Text);

                try
                {
                    int Shopp = Convert.ToInt32(TxtQuantity.Text);
                    int ResutlTotal = Price * Shopp;
                    resultFinish += ResutlTotal;


                    int QuantitiyFinish = Quantity - Shopp;
                    selectedItem.SubItems[2].Text = Convert.ToString(QuantitiyFinish);
                    int Quantity_Shopp = Convert.ToInt32(TxtQuantity.Text);

                    LblResult.Text = "$ " + Convert.ToString(resultFinish);
                }
                catch (FormatException)
                {
                    MessageBox.Show("El valor ingresado no es válido. Por favor, ingresa un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                using (StreamWriter writer = new StreamWriter(Url_txt_productos))
                {
                    foreach (ListViewItem item in LstViewDataProductos.Items)
                    {
                        // Construir una cadena con todos los datos del elemento separados por espacios
                        string line = $"{item.Text} {item.SubItems[1].Text} {item.SubItems[2].Text} {item.SubItems[3].Text}";
                        writer.WriteLine(line); // Escribir la línea en el archivo
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem para editar");
            }

            


        }

    }

    

}