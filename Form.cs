using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AmazingQuotation
{
    public partial class Quotation : Form
    {
        private string m_exePath = string.Empty;
        public Quotation()
        {
            InitializeComponent();
            HandlerClothingStore();
            HandlerSeller();
            HandlerHistory();
            radioStandard.Checked = true;
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
            ClothingStore clothingStore = new ClothingStore("Gucci", "Mitre 325", stock);
            lblClothingStore.Text = clothingStore.name;
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

        private string HandlerSeller()
        {
            Seller seller = new Seller(37, "Lautaro", "Zarandón");
            string user = seller.name + " " + seller.lastname + " id: " + seller.id_seller;
            lblSeller.Text = user;
            return user;
        }

        private void radioBtnShirt_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnChupin.Checked = false;
            radioBtnCommonPant.Checked = false;
            UpdateStock();
        }

        private void radioBtnPant_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStock();
        }

        private void UpdateStock()
        {
            ArrayList stock = GetStock();
            Shirts first = (Shirts)stock[0];
            Shirts second = (Shirts)stock[1];
            Shirts third = (Shirts)stock[2];
            Shirts four = (Shirts)stock[3];
            Pants five = (Pants)stock[4];
            Pants six = (Pants)stock[5];
            int total;
            if (radioBtnShirt.Checked)
            {
                total = first.quantity + second.quantity + third.quantity+ four.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnShort.Checked)
            {
                total = first.quantity + second.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnLong.Checked)
            {
                total = third.quantity + four.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnCommon.Checked && radioBtnShort.Checked)
            {
                total = second.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnMao.Checked && radioBtnShort.Checked)
            {
                total = first.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnCommon.Checked && radioBtnLong.Checked)
            {
                total = third.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnMao.Checked && radioBtnLong.Checked)
            {
                total = four.quantity;
                txtStock.Text = total.ToString();
            }
            // PANTS
            if (radioBtnPant.Checked)
            {
                total = five.quantity + six.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnChupin.Checked)
            {
                total = five.quantity;
                txtStock.Text = total.ToString();
            }
            if (radioBtnCommonPant.Checked)
            {
                total = six.quantity;
                txtStock.Text = total.ToString();
            }
        }

        private void radioBtnShort_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = false;
            radioBtnShirt.Checked = true;
            UpdateStock();
        }

        private void radioBtnLong_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = false;
            radioBtnShirt.Checked = true;
            UpdateStock();
        }

        private void radioBtnCommon_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = false;
            radioBtnShirt.Checked = true;
            UpdateStock();
        }

        private void radioBtnMao_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = false;
            radioBtnShirt.Checked = true;
            UpdateStock();
        }

        private void radioBtnChupin_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = true;
            radioBtnShirt.Checked = false;
            UpdateStock();
        }

        private void radioBtnCommonPant_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnPant.Checked = true;
            radioBtnShirt.Checked = false;
            UpdateStock();
        }

        private void radioBtnPant_CheckedChanged_1(object sender, EventArgs e)
        {
            radioBtnCommon.Checked = false;
            radioBtnShort.Checked = false;
            radioBtnLong.Checked = false;
            radioBtnMao.Checked = false;
            UpdateStock();
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            if ((txtQuantity.Value) > (txtStock.Value))
            {
                MessageBox.Show("You are entering a value greater than what is available","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUnitprice.Value == 0 || txtQuantity.Value == 0)
            {
                MessageBox.Show("Please enter unit price or quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float total = (float)txtUnitprice.Value * (float)txtQuantity.Value;
                if (radioBtnShort.Checked) 
                { 
                    total = (float)(total * 0.9);
                }
                if (radioBtnMao.Checked)
                {
                    total = (float)(total * 1.03);
                }
                if (radioBtnChupin.Checked)
                {
                    total = (float)(total * 0.88);
                }
                if(radioPremium.Checked)
                {
                    total = (float)(total * 1.30);
                }
                string res = total.ToString();
                lblResult.Text = res;
                HandlerLog(res);
                HandlerHistory();
            }
        }

        private void HandlerLog(string res)
        {
            string log = "";
            if (radioBtnShirt.Checked)
            {
                log = "Remera";
            }
            else {
                log = "Pantalon";
            }
            _ = new LogWriter("El usuario " + HandlerSeller() + " consulto: " + log + ", el total fue: $" + res);
        }

        private void HandlerHistory()
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                var str = File.ReadAllText(m_exePath + "\\" + "log.txt");
                txtHistory.Text = str;
            }
            catch (Exception)
            {
            }
        }
    }
}
