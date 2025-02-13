namespace kalkRachunku
{
    public partial class MainPage : ContentPage
    {
        double procent = 0;
        double kwotaRachunku = 0;
        int osoby = 1;

        public MainPage()
        {
            InitializeComponent();
        }


        private void napiwek_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            procent = Math.Floor(e.NewValue);
            napiwekTxt.Text = ("Ustaw procent napiwku (" + Math.Floor(procent).ToString() + "%): ");
            oblicz();
        }

        private void kwota_Completed(object sender, EventArgs e)
        {
            kwotaRachunku = double.Parse(kwota.Text);
            oblicz();
        }

        private void dodajOsobe_Clicked(object sender, EventArgs e)
        {
            osoby++;
            liczbaOsob.Text = "Liczba osob: " + osoby.ToString();
            oblicz();
        }

        private void usunOsobe_Clicked(object sender, EventArgs e)
        {
            if (osoby == 1)
            {
                return;
            } else osoby--;
            liczbaOsob.Text = "Liczba osob: " + osoby.ToString();
            oblicz();
        }

        private void a_Clicked(object sender, EventArgs e)
        {
            procent = 10;
            napiwek.Value = procent;
        }

        private void b_Clicked(object sender, EventArgs e)
        {
            procent = 15;
            napiwek.Value = procent;
        }

        private void c_Clicked(object sender, EventArgs e)
        {
            procent = 20;
            napiwek.Value = procent;
        }

        private void oblicz()
        {
            wartKwota.Text = "Kwota: " + kwotaRachunku;
            wartNapiwek.Text = "Napiwek: " + (Math.Round((procent / 100) * kwotaRachunku, 3));
            lacznaKwota.Text = "Łączna kwota: " + (Math.Round(kwotaRachunku + ((procent / 100) * kwotaRachunku), 3));
            if (osoby > 1)
            {
                wartKwota.Text = "Kwota: " + (Math.Round(kwotaRachunku / osoby, 3));
                wartNapiwek.Text = "Napiwek: " + (Math.Round(((procent / 100) * kwotaRachunku) / osoby, 3));
                lacznaKwota.Text = "Łączna kwota: " + (Math.Round((kwotaRachunku + ((procent / 100) * kwotaRachunku)) / osoby, 3));
            }
        }
    }

}
