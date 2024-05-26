using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace inventor_manager
{
    
    public partial class Add_nventory : Form
    {
        string Url_exel_productos = "C:\\Users\\1gren\\Documents\\prductos.xlsx";
        public Add_nventory()
        {
            InitializeComponent();


        }
        private Image _receivedImage;
        public Image ReceivedImage
        {
            get { return _receivedImage; }
            set
            {
                _receivedImage = value;
               PicturUser.Image = _receivedImage;
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
    }
}
