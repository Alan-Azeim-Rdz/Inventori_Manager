using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Paragraph = iTextSharp.text.Paragraph;


namespace inventor_manager
{
    public partial class CashRegister : Form

    {
        Product_Sale selectedProduct;
        int selectedProductStock;
        int resultFinish = 0;



        string Url_txt_productos = "C:\\Users\\1gren\\Documents\\archivos_R\\datos.txt";
        public CashRegister()
        {
            InitializeComponent();
            Filllistview();
        }



        private System.Drawing.Image receivedImage;
        public System.Drawing.Image ReceivedImage
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
                string Price_Rplace = selectedItem.SubItems[1].Text.Replace("$", "");

                string productName = selectedItem.Text;
                double productPrice = Convert.ToDouble(Price_Rplace);
                int productStock = Convert.ToInt32(selectedItem.SubItems[2].Text);

                selectedProduct = new Product_Sale(productName, productPrice, productStock);
                LblSelection.Text = selectedProduct.ToString();
                selectedProductStock = productStock;

            }
            else
            {
                selectedProduct = new Product_Sale();
                MessageBox.Show("Seleccione un ítem para editar. No puede estar vacio " + selectedProduct);
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
                string mark = selectedItem.SubItems[3].Text;

                try
                {
                    int quantityToSell = Convert.ToInt32(TxtQuantity.Text);

                    // Validate quantity to sell against available stock
                    if (quantityToSell <= selectedProductStock)
                    {
                        // Update total result
                        resultFinish += CalculateTotalResult(selectedProduct, quantityToSell);
                        LblResult.Text = "$ " + Convert.ToString( resultFinish);


                        // Update ListView ticket
                        ListViewItem itemTicket = new ListViewItem(selectedProduct.Name);
                        ListVTicket.Items.Add(itemTicket);
                        itemTicket.SubItems.Add(selectedProduct.Price.ToString());
                        itemTicket.SubItems.Add(quantityToSell.ToString());
                        itemTicket.SubItems.Add(mark); // Assuming discount is 0

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

        private int CalculateTotalResult(Product_Sale selectedProduct, int quantityToSell)
        {
            int totalResult = (int)(selectedProduct.Price * quantityToSell);
            return totalResult;
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
            if (LstViewDataProductos.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista para convertir a JSON.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Create a List to hold product data in a JSON-friendly format
                List<Dictionary<string, object>> productList = new List<Dictionary<string, object>>();

                // Extract and format product data from ListView items
                foreach (ListViewItem item in ListVTicket .Items)
                {
                    Dictionary<string, object> productData = new Dictionary<string, object>();
                    productData.Add("Nombre", item.Text);
                    productData.Add("Precio", item.SubItems[1].Text);
                    productData.Add("Stock", item.SubItems[2].Text);
                    productData.Add("Marca", item.SubItems[3].Text);


                    productList.Add(productData);
                }
                Dictionary<string, object> productData2 = new Dictionary<string, object>();
                productData2.Add("Total", LblResult.Text);
                productList.Add(productData2);

                string jsonString = JsonConvert.SerializeObject(productList, Formatting.Indented);

                // Save the JSON string to a file
                string filePath = Path.Combine(Path.GetDirectoryName(Url_txt_productos), "ticket.json");
                File.WriteAllText(filePath, jsonString);

                MessageBox.Show("Ticket generado exitosamente en formato JSON: " + filePath, "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el ticket JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }







        private void BtnTicketExcel_Click(object sender, EventArgs e)
        {
            int itemCount = ListVTicket.Items.Count;
            string[,] data = new string[itemCount, 4];

            for (int i = 0; i < itemCount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    data[i, j] = ListVTicket.Items[i].SubItems[j].Text;
                }
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = "Datos.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreateExcelFile(saveFileDialog.FileName, data);
                MessageBox.Show("Archivo Excel creado con éxito!");
            }

        }



        private void CreateExcelFile(string filePath, string[,] data)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // Crear la parte del libro de trabajo
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                // Crear la parte de la hoja de trabajo
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Crear hojas
                Sheets sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());

                // Crear una hoja de cálculo
                Sheet sheet = new Sheet()
                {
                    Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Ticket"
                };

                sheets.Append(sheet);

                // Llenar la hoja de cálculo con datos
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                for (int row = 0; row < data.GetLength(0); row++)
                {
                    Row newRow = new Row();
                    for (int col = 0; col < data.GetLength(1); col++)
                    {
                        Cell newCell = new Cell()
                        {
                            CellValue = new CellValue(data[row, col]),
                            DataType = CellValues.String
                        };
                        newRow.Append(newCell);
                    }
                    sheetData.Append(newRow);
                }

                workbookPart.Workbook.Save();
            }
        }






        private void BtnPdfTicket_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(saveFileDialog.FileName);
                MessageBox.Show("PDF creado exitosamente.");
            }

        }





        private void ExportToPdf(string filePath)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            try
            {
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Añadir el título del documento
                document.Add(new iTextSharp.text.Paragraph("Total " + LblResult.Text ));
                document.Add(new iTextSharp.text.Paragraph(" ")); // Espacio en blanco

                // Crear una tabla con el número de columnas del ListView
                PdfPTable table = new PdfPTable(ListVTicket.Columns.Count);

                // Añadir los encabezados de las columnas
                foreach (ColumnHeader column in ListVTicket.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Añadir las filas de datos
                foreach (ListViewItem item in ListVTicket.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        table.AddCell(subItem.Text);
                    }
                }

                // Añadir la tabla al documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el PDF: {ex.Message}");
            }
            finally
            {
                document.Close();
            }
        }

    }
}
