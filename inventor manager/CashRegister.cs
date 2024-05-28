
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace inventor_manager
{
    public partial class CashRegister : Form

    {
        Producto_Sale selectedProduct;
        int selectedProductStock;
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

                string productName = selectedItem.Text;
                double productPrice = Convert.ToDouble(selectedItem.SubItems[1].Text);
                int productStock = Convert.ToInt32(selectedItem.SubItems[2].Text);

                selectedProduct = new Producto_Sale(productName, productPrice, productStock);
                selectedProductStock = productStock;

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
                    int quantityToSell = Convert.ToInt32(TxtQuantity.Text);

                    // Validate quantity to sell against available stock
                    if (quantityToSell <= selectedProductStock)
                    {
                        // Update total result
                        resultFinish += (int)(selectedProduct.Price * quantityToSell);
                        LblResult.Text = "$ " + resultFinish;

                        // Update ListView ticket
                        ListViewItem itemTicket = new ListViewItem(selectedProduct.Name);
                        ListVTicket.Items.Add(itemTicket);
                        itemTicket.SubItems.Add(selectedProduct.Price.ToString());
                        itemTicket.SubItems.Add(quantityToSell.ToString());
                        itemTicket.SubItems.Add(selectedProduct.Price.ToString()); // Assuming discount is 0

                        // Update product stock
                        selectedProduct.ReduceStock((quantityToSell));
                        selectedProductStock -= quantityToSell;

                        // Update ListView product stock
                        LstViewDataProductos.SelectedItems[0].SubItems[2].Text = selectedProductStock.ToString();

                        // Update product file
                        UpdateProductFile();

                    }
                    else
                    {
                        MessageBox.Show("La cantidad seleccionada excede la cantidad disponible.");
                    }
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
        private void UpdateProductFile()
        {
            try
            {
                if (File.Exists(Url_txt_productos))
                {
                    // Leer todas las líneas del archivo
                    string[] lines = File.ReadAllLines(Url_txt_productos);

                    // Crear una lista para almacenar los datos actualizados del producto
                    List<string> updatedLines = new List<string>();

                    // Procesar cada línea
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(' ');
                        string nombreProducto = parts[0];

                        // Actualizar stock para el producto seleccionado
                        if (nombreProducto == selectedProduct.Name)
                        {
                            parts[2] = selectedProductStock.ToString(); // Actualizar valor de stock
                        }

                        // Construir la línea actualizada
                        string updatedLine = string.Join(" ", parts);
                        updatedLines.Add(updatedLine);
                    }

                    // Escribir los datos actualizados en el archivo
                    File.WriteAllLines(Url_txt_productos, updatedLines);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el archivo de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTicketJason_Click(object sender, EventArgs e)
        {

        }

        private void BtnTicketExcel_Click(object sender, EventArgs e)
        {

            
        }



    }
}