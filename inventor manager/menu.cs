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

        private void BtnSouldProduct_Click(object sender, EventArgs e)
        {
            Edit_Inventory products_Sold = new Edit_Inventory();
            products_Sold.Show();
            products_Sold.ReceivedImage = PictureImagePhoto.Image;
        }

        private void BtnCashRegister_Click(object sender, EventArgs e)
        {
            CashRegister cash = new CashRegister();
            cash.Show();
            cash.ReceivedImage = PictureImagePhoto.Image;
        }
    }
}
