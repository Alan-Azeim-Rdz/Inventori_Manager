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
    public partial class menu : Form
    {
        public menu()
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
                PictureImagePhoto.Image = _receivedImage;
            }
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Add_nventory form1 = new Add_nventory();
            form1.Show();
            form1.ReceivedImage = PictureImagePhoto.Image;
        }

        private void BtnSouldProduct_Click(object sender, EventArgs e)
        {
            Products_sold products_Sold = new Products_sold();
            products_Sold.Show();
            products_Sold.ReceivedImage = PictureImagePhoto.Image;
        }
    }
}
