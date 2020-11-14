using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingQuotation
{
    public partial class Quotation : Form
    {
        public Quotation()
        {
            InitializeComponent();
            HandlerClothingStore();
            HandlerSeller();
        }

        private void LinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            linkGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/zarandonlautaro");
        }

        private void HandlerClothingStore()
        {
            ArrayList stock = GetStock();
            Console.WriteLine(stock[0]);
            ClothingStore clothingStore = new ClothingStore("Gucci", "Mitre 325", stock);
            label7.Text = clothingStore.name;
            label9.Text = clothingStore.address;
        }

        private ArrayList GetStock()
        {
            Shirts shirtShortMao = new Shirts(true, true, 200);
            Shirts shirtShort = new Shirts(true, false, 300);
            Shirts shirtLongMao = new Shirts(false, true, 150);
            Shirts shirtLong = new Shirts(false, false, 350);

            Pants pantNormal = new Pants(false, 1500);
            Pants pantChupin = new Pants(true, 500);

            ArrayList stock = new ArrayList
            {
                shirtShortMao,
                shirtShort,
                shirtLongMao,
                shirtLong,
                pantNormal,
                pantChupin,
            };

            return stock;
        }

        private void HandlerSeller()
        {
            Seller seller = new Seller(37, "Lautaro", "Zarandón");
            label13.Text = seller.name + " " + seller.lastname;
        }
    }
}
