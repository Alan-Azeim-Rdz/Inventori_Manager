using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventor_manager
{
    public partial class Edit_Inventory : Form
    {
        private string Url_txt_productos = "C:\\Users\\1gren\\Documents\\archivos_R\\datos.txt";
        public Edit_Inventory()
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
                        for (int i = 1; i < partes.Length
                            ; i++)
                        {
                            item.SubItems.Add(partes[i]);
                        }

                        // Agregar el item al ListView
                        ListViewDataProduct.Items.Add(item);
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
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (ListViewDataProduct.SelectedItems.Count > 0)
            {
                var selectedItem = ListViewDataProduct.SelectedItems[0];
                TxtAddName.Text = selectedItem.Text;
                TxtPrice.Text = selectedItem.SubItems[1].Text;
                TxtQuanity.Text = selectedItem.SubItems[2].Text;
                TxtMark.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                MessageBox.Show("Seleccione un ítem para editar.");
            }
        }
        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (!(TxtAddName.Text == "") && !(TxtPrice.Text == "") && !(TxtQuanity.Text == "") && !(TxtMark.Text == ""))
            {
                if (ListViewDataProduct.SelectedItems.Count > 0)
                {
                    // Obtener el elemento seleccionado
                    string Name_without_spaces = TxtAddName.Text.Replace(" ", "-");
                    string Mark_without_spaces = TxtMark.Text.Replace(" ", "-");
                    var selectedItem = ListViewDataProduct.SelectedItems[0];

                    // Actualizar los valores en los subitems del elemento seleccionado
                    selectedItem.Text = Name_without_spaces;
                    selectedItem.SubItems[1].Text = TxtPrice.Text;
                    selectedItem.SubItems[2].Text = TxtQuanity.Text;
                    selectedItem.SubItems[3].Text = Mark_without_spaces;

                    using (StreamWriter writer = new StreamWriter(Url_txt_productos))
                    {
                        // Recorre los elementos del ListView y escribe cada dato en una línea
                        foreach (ListViewItem item in ListViewDataProduct.Items)
                        {
                            // Construir una cadena con todos los datos del elemento separados por espacios
                            string line = $"{item.Text} {item.SubItems[1].Text} {item.SubItems[2].Text} {item.SubItems[3].Text}";
                            writer.WriteLine(line); // Escribir la línea en el archivo
                        }
                    }

                    // Opcionalmente, puedes mostrar un mensaje de confirmación
                    MessageBox.Show("El producto ha sido actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Seleccione un ítem para editar");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deven estar llenos para poder ingresar");
            }
           
        }





       

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelect(ListViewDataProduct, Url_txt_productos);
        }

        public void DeleteSelect(System.Windows.Forms.ListView listView,string Url)
        {
            if (listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    listView.Items.Remove(item);
                }
                ActualizarTxt(listView, Url);
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados para eliminar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarTxt(System.Windows.Forms.ListView listView, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                //// Write the header row if it exists
                //if (listView.Columns.Count > 0)
                //{
                //    string headerRow = "";
                //    foreach (ColumnHeader column in listView.Columns)
                //    {
                //        headerRow += column.Text + " ";
                //    }
                //    writer.WriteLine(headerRow.Trim());
                //}

                // Write each remaining item's data
                foreach (ListViewItem item in listView.Items)
                {
                    string dataRow = "";
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        dataRow += item.SubItems[i].Text + " ";
                    }
                    writer.WriteLine(dataRow.Trim());
                }
            }
        }
    }
}
