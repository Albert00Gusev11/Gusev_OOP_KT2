using System;
using System.Windows.Forms;

namespace Gusev_OOP_KT2
{
    public partial class AG_main : Form
    {
        int m;
        int raha;
        Random rnd = new Random();

        public AG_main()
        {
            InitializeComponent();
        }

        private void AG_main_Load(object sender, EventArgs e)
        {
            AG_ok.Enabled = false;
            AG_start.Enabled = true;
            AG_lblKirjeldus.Visible = true;
        }

        private void AG_ok_Click(object sender, EventArgs e)
        {
            int k = rnd.Next(0, 11);
            AG_lblRand.Text = Convert.ToString(k);

            raha++;

            m = Convert.ToInt32(AG_lblKatse.Text);
            m++;
            AG_lblKatse.Text = Convert.ToString(m);

            if (k == 0 || k == 10)
            {
                AG_ok.Enabled = false;
                AG_start.Enabled = true;
                AG_lblKirjeldus.Visible = true;

                if (m < 10)
                {
                    AG_Pilt.Image = AG_pilt1.Image;
                    AG_lblKirjeldus.Text = $"Vahva! Katseid oli vähem kui 10. Te võitsite {raha} euro!";
                }
                else if (m > 10)
                {
                    AG_Pilt.Image = AG_pilt2.Image;
                    AG_lblKirjeldus.Text = $"Katseid on rohkem kui 10 ({m}). Kahjuks kaotasite {raha} euro.";
                }
                else
                {
                    AG_Pilt.Image = AG_pilt2.Image;
                    AG_lblKirjeldus.Text = $"Katseid oli täpselt 10. Viik.";
                }
            }
        }

        private void AG_start_Click(object sender, EventArgs e)
        {
            m = 0;
            raha = 0;
            AG_lblKatse.Text = Convert.ToString(m);
            AG_lblRand.Text = "";

            AG_ok.Enabled = true;
            AG_start.Enabled = false;

            AG_Pilt.Image = AG_pilt3.Image;

            AG_lblKirjeldus.Text = "";
            AG_lblKirjeldus.Visible = true;
            AG_ok.Focus();
        }
    }
}
