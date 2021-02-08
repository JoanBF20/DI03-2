using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03_2
{
    public partial class Form1 : Form
    {
        private ProductModel productModel;
        public Form1()
        {
            InitializeComponent();
            SetRandomProduct();
        }

        private void SetRandomProduct()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(0, 128);
            productModel = DataAcces.GetProductModel(randomInt);
            name.Text = productModel.Name;
            modelID.Text = "ID: " + productModel.ProductModelID;
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            pictureBox1.Image = largePhoto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetRandomProduct();
        }
    }
}
