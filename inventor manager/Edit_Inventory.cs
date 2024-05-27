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
                        for (int i = 1; i < partes.Length; i++)
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
            if (ListViewDataProduct.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                var selectedItem = ListViewDataProduct.SelectedItems[0];

                // Actualizar los valores en los subitems del elemento seleccionado
                selectedItem.Text = TxtAddName.Text;
                selectedItem.SubItems[1].Text = TxtPrice.Text;
                selectedItem.SubItems[2].Text = TxtQuanity.Text;
                selectedItem.SubItems[3].Text = TxtMark.Text;

                using (StreamWriter writer = new StreamWriter(Url_txt_productos))
                {
                    // Recorre los elementos del ListView y escribe cada dato en el archivo
                    foreach (ListViewItem item in ListViewDataProduct.Items)
                    {
                        writer.WriteLine(item.Text); // Escribe el texto del primer subítem
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            writer.WriteLine(subItem.Text); // Escribe el texto de los subítems adicionales
                        }
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

    }
}
