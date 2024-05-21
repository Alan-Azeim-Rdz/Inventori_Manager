using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Xml;

namespace inventor_manager
{
    public partial class Form1 : Form
    {
        string Url_exel_productos = "C:\\Users\\1gren\\Documents\\prductos.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(!(TxtAddName.Text == "")&&!(TxtPrice.Text == "") && !(TxtQuanity.Text == "") && !(TxtMark.Text == ""))
            {
                ListViewItem NewItemLstData = new ListViewItem(TxtAddName.Text);
                LstViewDataProductos.Items.Add(NewItemLstData);
                NewItemLstData.SubItems.Add(TxtPrice.Text);
                NewItemLstData.SubItems.Add(TxtQuanity.Text);
                NewItemLstData.SubItems.Add(TxtMark.Text);
            }
            else
            {
                MessageBox.Show("Todos los campos deven estar llenos para poder ingresar");
            }
           

        }
    }
}
