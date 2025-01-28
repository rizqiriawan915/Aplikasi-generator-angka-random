namespace Aplikasi_Generator_Angka_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtAngkaMinimal.Text, out numA);
            bool isNumericB = int.TryParse(txtAngkaMaximal.Text, out numB);
            if(isNumericA && isNumericB)
            {
                Random rand = new Random();
                int terambil = rand.Next(numA, numB);
                txtAngkaTerpilih.Text = terambil.ToString();
            }
            else
            {
                MessageBox.Show("Input yang anda masukkan invalid!", "Error");
            }
        }
    }
}
