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
            LstViewDataProductos.Items.Add(TxtSearchName.Text);
        }
    }
}
