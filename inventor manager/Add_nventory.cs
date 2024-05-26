using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace inventor_manager
{
    
    public partial class Add_nventory : Form
    {
        string Url_exel_productos = "C:\\Users\\1gren\\Documents\\prductos.xlsx";
        string Url_txt_productos = "C:\\Users\\1gren\\Documents\\archivos_R\\datos.txt";
        public Add_nventory()
        {
            InitializeComponent();

        }
        private Image receivedImage;
        public Image ReceivedImage
        {
            get { return receivedImage; }
            set
            {
                receivedImage = value;
               PicturUser.Image = receivedImage;
            }
        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(!(TxtAddName.Text == "")&&!(TxtPrice.Text == "") && !(TxtQuanity.Text == "") && !(TxtMark.Text == ""))
            {
                ListViewItem NewItemLstData = new ListViewItem(TxtAddName.Text);
                try
                {
                    LstViewDataProductos.Items.Add(NewItemLstData);
                    Product producto = new Product(Convert.ToInt32(TxtPrice.Text), Convert.ToInt32(TxtQuanity.Text), TxtMark.Text);


                    NewItemLstData.SubItems.Add(Convert.ToString(producto.Price));
                    NewItemLstData.SubItems.Add(Convert.ToString(producto.Quantity));
                    NewItemLstData.SubItems.Add(producto.Mark);

                    string product_for_txt = TxtAddName.Text + " " + producto.ToString() + " \n ";
                    try
                    {
                        // Escribe el contenido en el archivo especificado
                        File.AppendAllText(Url_txt_productos, product_for_txt + Environment.NewLine);

                        Console.WriteLine("El archivo se ha guardado correctamente en: " + product_for_txt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al guardar el archivo: " + ex.Message);
                    }

                }
                catch (System.InvalidCastException) 
                {
                    LstViewDataProductos.Items.Remove(NewItemLstData);
                    MessageBox.Show("alguno de los datos enviados esta mal porfavor verifique su escritura");

                }
                catch (System.FormatException)
                {
                    LstViewDataProductos.Items.Remove(NewItemLstData);
                    MessageBox.Show("alguno de los datos enviados esta mal porfavor verifique su escritura");

                }
            }
            else
            {
                MessageBox.Show("Todos los campos deven estar llenos para poder ingresar");
            }
           

        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            menu MainMenu = new menu();
            MainMenu.Show();
        }
    }
}
