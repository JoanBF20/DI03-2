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
        private int max;
        public Form1()
        {
            InitializeComponent();
            max = DataAcces.CountModel();
            toolTip1.SetToolTip(pictureBox1, "Click to display another product");
            SetRandomProduct();
        }

        private void SetRandomProduct()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(0, max);
            productModel = DataAcces.GetProductModel(randomInt);
            if (productModel != null)
            {
                name.Text = productModel.Name;
                modelID.Text = "ID: " + productModel.ProductModelID;
                MemoryStream ms = new MemoryStream(productModel.LargePhoto);
                Image largePhoto = Image.FromStream(ms);
                pictureBox1.Image = largePhoto;

                productModel.Products = DataAcces.GetProducts(randomInt);
                setPrice();
                flowLayoutPanel1.Controls.Clear();

                List<string> sizes = getSizes();
                productID.Text = "";
                foreach (String size in sizes)
                {
                    if (size != null)
                    {
                        Button sizeButton = new Button();
                        sizeButton.Text = size;
                        sizeButton.Name = "sizeButton" + size;
                        sizeButton.Click += (sender, EventArgs) => { sizeButton_Click(sender, EventArgs, size); };
                        flowLayoutPanel1.Controls.Add(sizeButton);
                    }
                }
            }
        }

        private List<string> getSizes()
        {
            List<string> sizes = new List<string>();
            foreach (Product product in productModel.Products)
            {
                if (!sizes.Contains(product.Size))
                {
                    sizes.Add(product.Size);
                }
            }
            return sizes;
        }

        private void setProductsBySize(string size)
        {
            string productIDs = "";
            if (productModel != null)
            {
                foreach (Product product in productModel.Products)
                {
                    if (product.Size.Equals(size))
                    {
                        productIDs += product.ProductID + " ";
                    }
                }
                productID.Text = productIDs;
            }
        }

        private void setPrice()
        {
            List<string> prices = new List<string>();
            if (productModel != null)
            {
                foreach (Product product in productModel.Products)
                {
                    if (!prices.Contains(product.ListPrice))
                    {
                        prices.Add(product.ListPrice);
                    }
                }
                
                if (prices.Count > 1)
                {
                    if (prices.Contains("S"))
                    {
                        priceLabel.Text =  getSizePrice("S");
                    } else if (prices.Contains("M"))
                    {
                        priceLabel.Text = getSizePrice("S");
                    } else if (prices.Contains("L"))
                    {
                        priceLabel.Text = getSizePrice("S");
                    }
                    else if (prices.Contains("XL"))
                    {
                        priceLabel.Text = getSizePrice("S");
                    } else
                    {
                        prices.Sort();
                        priceLabel.Text = prices.First();
                    }
                } else
                {
                    priceLabel.Text = prices.First();
                }
            }
        }

        private string getSizePrice(string size)
        {
            foreach (Product product in productModel.Products)
            {
                if (!size.Contains(product.Size))
                {
                    return product.ListPrice;
                }
            }
            return "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetRandomProduct();
        }

        private void sizeButton_Click(object sender, EventArgs e,string size)
        {
            setProductsBySize(size);
        }
    }
}
