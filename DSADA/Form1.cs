using System;
using System.Text;
using System.Windows.Forms;

namespace INF._04_01_23._01_SG
{
    public partial class Form1 : Form
    {
        private string wygenerowaneHaslo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void generuj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(znaki.Text, out int dlugosc) || dlugosc < 1)
            {
                PokazBlad("Wprowadź prawidłową dodatnią liczbę znaków!");
                return;
            }

            string zestaw = ZbudujZestawZnakow();

            if (zestaw.Length == 0)
            {
                PokazBlad("Musisz zaznaczyć przynajmniej jeden typ znaków!");
                return;
            }

            wygenerowaneHaslo = GenerujHaslo(zestaw, dlugosc);

            MessageBox.Show(
                $"Wygenerowane hasło:\n{wygenerowaneHaslo}",
                "Sukces",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (BrakDanych())
            {
                PokazBlad("Uzupełnij wszystkie pola pracownika!");
                return;
            }

            string info =
                $"Imię: {imie.Text}\n" +
                $"Nazwisko: {nazwisko.Text}\n" +
                $"Stanowisko: {stanowisko.SelectedItem}\n" +
                $"Hasło: {wygenerowaneHaslo}";

            MessageBox.Show(
                $"Dodano pracownika:\n\n{info}",
                "Sukces",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ------- METODY POMOCNICZE ------- //

        private string ZbudujZestawZnakow()
        {
            StringBuilder sb = new StringBuilder();

            if (litery.Checked)
                sb.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");

            if (cyfry.Checked)
                sb.Append("0123456789");

            if (specjalne.Checked)
                sb.Append("!@#$%^&*()-_=+<>?");

            return sb.ToString();
        }

        private string GenerujHaslo(string zestaw, int dl)
        {
            Random rnd = new Random();
            StringBuilder wynik = new StringBuilder();

            for (int i = 0; i < dl; i++)
            {
                wynik.Append(zestaw[rnd.Next(zestaw.Length)]);
            }

            return wynik.ToString();
        }

        private bool BrakDanych()
        {
            return string.IsNullOrWhiteSpace(imie.Text)
                || string.IsNullOrWhiteSpace(nazwisko.Text)
                || stanowisko.SelectedIndex == -1;
        }

        private void PokazBlad(string msg)
        {
            MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
