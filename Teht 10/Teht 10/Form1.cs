namespace Teht_10
{
    public partial class BMIform : Form
    {
        public BMIform()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if (painoindeksi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Blue;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = "Painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 40)
            {
                VastausLB.Text = "Painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Yellow;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Yellow;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}