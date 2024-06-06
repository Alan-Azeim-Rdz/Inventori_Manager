using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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


        private void Btnaccept_Click(object sender, EventArgs e)
        {
            try
            {


                if (ComBoxElection.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecciona una acción en la caja de ítems");
                    return;
                }
                else
                {

                    string selection = ComBoxElection.SelectedItem.ToString();

                    switch (selection)
                    {
                        case "Add":


                            if (ListViewDataProduct.SelectedItems.Count > 0)
                            {
                                MessageBox.Show("No puedes agregar un nuevo producto mientras estás editando.");
                                return;
                            }

                            if (!string.IsNullOrEmpty(TxtAddName.Text) && !string.IsNullOrEmpty(TxtPrice.Text) && !string.IsNullOrEmpty(TxtQuanity.Text) && !string.IsNullOrEmpty(TxtMark.Text))
                            {
                                string Name_without_spaces = TxtAddName.Text.Replace(" ", "-");
                                string Mark_without_spaces = TxtMark.Text.Replace(" ", "-");

                                bool isDuplicate = false;
                                foreach (ListViewItem item in ListViewDataProduct.Items)
                                {
                                    if (item.Text == Name_without_spaces &&
                                        item.SubItems[1].Text == TxtPrice.Text &&
                                        item.SubItems[2].Text == TxtQuanity.Text &&
                                        item.SubItems[3].Text == Mark_without_spaces)
                                    {
                                        isDuplicate = true;
                                        break;
                                    }
                                }

                                if (!isDuplicate)
                                {
                                    ListViewItem NewItemLstData = new ListViewItem(Name_without_spaces);
                                    try
                                    {
                                        ListViewDataProduct.Items.Add(NewItemLstData);

                                        IProduct producto;

                                        if (CheckBoxPerecedero.Checked)
                                        {
                                            DateTime expirationDate;
                                            if (DateTime.TryParse(TxtExpirationDate.Text, out expirationDate))
                                            {
                                                producto = new Perishable(Convert.ToDouble(TxtPrice.Text), Convert.ToInt32(TxtQuanity.Text), TxtMark.Text, expirationDate);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Fecha de caducidad inválida");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            producto = new Not_Perishable(Convert.ToDouble(TxtPrice.Text), Convert.ToInt32(TxtQuanity.Text), TxtMark.Text);
                                        }

                                        NewItemLstData.SubItems.Add(Convert.ToString(producto.Price));
                                        NewItemLstData.SubItems.Add(Convert.ToString(producto.Quantity));
                                        NewItemLstData.SubItems.Add(Mark_without_spaces);

                                        if (producto is Perishable)
                                        {
                                            NewItemLstData.SubItems.Add(((Perishable)producto).ExpirationDate.ToString("yyyy-MM-dd"));
                                        }
                                        else
                                        {
                                            NewItemLstData.SubItems.Add("N/A");
                                        }

                                        string product_for_txt = Name_without_spaces + " " + producto.ToString() + " N/A";
                                        try
                                        {
                                            File.AppendAllText(Url_txt_productos, product_for_txt + Environment.NewLine);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                                        }
                                    }
                                    catch (System.InvalidCastException)
                                    {
                                        ListViewDataProduct.Items.Remove(NewItemLstData);
                                        MessageBox.Show("Alguno de los datos enviados está mal. Por favor verifique su escritura");
                                    }
                                    catch (System.FormatException)
                                    {
                                        ListViewDataProduct.Items.Remove(NewItemLstData);
                                        MessageBox.Show("Alguno de los datos enviados está mal. Por favor verifique su escritura");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El producto ya existe en la lista.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Todos los campos deben estar llenos para poder ingresar");
                            }

                            TxtAddName.Clear();
                            TxtMark.Clear();
                            TxtPrice.Clear();
                            TxtQuanity.Clear();
                            TxtExpirationDate.Clear();
                            break;

                        case "Edit":

                            ListViewDataProduct.Enabled = true;
                            if (!string.IsNullOrEmpty(TxtAddName.Text) && !string.IsNullOrEmpty(TxtPrice.Text) && !string.IsNullOrEmpty(TxtQuanity.Text) && !string.IsNullOrEmpty(TxtMark.Text))
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
                                    selectedItem.SubItems[3].Text = TxtMark.Text;

                                    // Verificar si el producto es perecedero y actualizar la fecha de caducidad
                                    string expirationDateText = CheckBoxPerecedero.Checked ? TxtExpirationDate.Text : "N/A";
                                    selectedItem.SubItems[4].Text = expirationDateText;

                                    using (StreamWriter writer = new StreamWriter(Url_txt_productos))
                                    {
                                        // Recorre los elementos del ListView y escribe cada dato en una línea
                                        foreach (ListViewItem item in ListViewDataProduct.Items)
                                        {
                                            // Construir una cadena con todos los datos del elemento separados por espacios
                                            string line = $"{item.Text} {item.SubItems[1].Text} {item.SubItems[2].Text} {item.SubItems[3].Text} {item.SubItems[4].Text}";
                                            writer.WriteLine(line);
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
                                MessageBox.Show("Todos los campos deben estar llenos para poder ingresar");
                            }

                            TxtAddName.Clear();
                            TxtMark.Clear();
                            TxtPrice.Clear();
                            TxtQuanity.Clear();

                            break;
                    }


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, inténtalo de nuevo.");
            }

        }






        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelect(ListViewDataProduct, Url_txt_productos);
            ListViewDataProduct.SelectedItems.Clear();
            ListViewDataProduct.Enabled = true;

            TxtAddName.Clear();
            TxtMark.Clear();
            TxtPrice.Clear();
            TxtQuanity.Clear();

        }

        public void DeleteSelect(System.Windows.Forms.ListView listView, string Url)
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

        private void ListViewDataProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewDataProduct.SelectedItems.Count > 0)
            {
                ListViewDataProduct.FullRowSelect = true;

                var selectedItem = ListViewDataProduct.SelectedItems[0];

                TxtAddName.Text = selectedItem.Text;
                TxtPrice.Text = selectedItem.SubItems[1].Text;
                TxtQuanity.Text = selectedItem.SubItems[2].Text;
                TxtMark.Text = selectedItem.SubItems[3].Text;

                // Verificar si el producto seleccionado es perecedero
                string expirationDateText = selectedItem.SubItems[4].Text;
                if (!string.IsNullOrEmpty(expirationDateText) && expirationDateText != "N/A")
                {
                    CheckBoxPerecedero.Checked = true;
                    TxtExpirationDate.Text = expirationDateText;
                }
                else
                {
                    CheckBoxPerecedero.Checked = false;
                    TxtExpirationDate.Text = "N/A"; // Establece "N/A" como valor predeterminado
                }

                ListViewDataProduct.Enabled = false;

                // Cambia el combo box a "Edit" y deshabilita la opción "Add"
                ComBoxElection.SelectedItem = "Edit";
                ComBoxElection.Enabled = false;

            }
            else
            {
                // Si no hay ningún elemento seleccionado, habilitar el combo box
                ComBoxElection.Enabled = true;
            }
        }

        private void BtnQuantityProductTotal_Click(object sender, EventArgs e)
        {
            ObtenerCantidadProductosTotales();
        }
        public DialogResult ObtenerCantidadProductosTotales()
        {
            int totalProductos = 0;

            try
            {
                if (File.Exists(Url_txt_productos))
                {
                    // Leer todas las líneas del archivo
                    string[] lineas = File.ReadAllLines(Url_txt_productos);

                    // Contar el número de líneas (cada línea representa un producto)
                    totalProductos = lineas.Length;
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

            return MessageBox.Show("los productos que se encuentran registrados en el almacen ahora son " + (Convert.ToString(totalProductos.ToString())));
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ListViewDataProduct.SelectedItems.Clear();
            ListViewDataProduct.Enabled = true;

            TxtAddName.Clear();
            TxtMark.Clear();
            TxtPrice.Clear();
            TxtQuanity.Clear();
        }
    }
}
