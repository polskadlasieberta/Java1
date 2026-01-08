namespace INF._04_01_23._01_SG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            stanowisko = new System.Windows.Forms.ComboBox();
            stanowiskolabel = new System.Windows.Forms.Label();
            nazwisko = new System.Windows.Forms.TextBox();
            nazwiskolabel = new System.Windows.Forms.Label();
            imielabel = new System.Windows.Forms.Label();
            imie = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            generuj = new System.Windows.Forms.Button();
            specjalne = new System.Windows.Forms.CheckBox();
            cyfry = new System.Windows.Forms.CheckBox();
            litery = new System.Windows.Forms.CheckBox();
            znakilabel = new System.Windows.Forms.Label();
            znaki = new System.Windows.Forms.TextBox();
            zatwierdz = new System.Windows.Forms.Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            groupBox1.Controls.Add(stanowisko);
            groupBox1.Controls.Add(stanowiskolabel);
            groupBox1.Controls.Add(nazwisko);
            groupBox1.Controls.Add(nazwiskolabel);
            groupBox1.Controls.Add(imielabel);
            groupBox1.Controls.Add(imie);
            groupBox1.Location = new System.Drawing.Point(10, 50);
            groupBox1.Size = new System.Drawing.Size(345, 285);
            groupBox1.Text = "Dane pracownika";

            stanowisko.Items.AddRange(new object[] {
                "Kierownik",
                "Starszy programista",
                "Młodszy programista",
                "Tester"
            });
            stanowisko.Location = new System.Drawing.Point(128, 130);
            stanowisko.Size = new System.Drawing.Size(198, 24);

            stanowiskolabel.Location = new System.Drawing.Point(25, 133);
            stanowiskolabel.Text = "Stanowisko";

            nazwisko.Location = new System.Drawing.Point(128, 88);
            nazwisko.Size = new System.Drawing.Size(198, 22);

            nazwiskolabel.Location = new System.Drawing.Point(25, 92);
            nazwiskolabel.Text = "Nazwisko";

            imielabel.Location = new System.Drawing.Point(25, 51);
            imielabel.Text = "Imię";

            imie.Location = new System.Drawing.Point(128, 45);
            imie.Size = new System.Drawing.Size(198, 22);

            groupBox2.Controls.Add(generuj);
            groupBox2.Controls.Add(specjalne);
            groupBox2.Controls.Add(cyfry);
            groupBox2.Controls.Add(litery);
            groupBox2.Controls.Add(znakilabel);
            groupBox2.Controls.Add(znaki);
            groupBox2.Location = new System.Drawing.Point(450, 50);
            groupBox2.Size = new System.Drawing.Size(345, 285);
            groupBox2.Text = "Generowanie hasła";

            generuj.BackColor = System.Drawing.Color.SteelBlue;
            generuj.ForeColor = System.Drawing.Color.White;
            generuj.Location = new System.Drawing.Point(115, 225);
            generuj.Size = new System.Drawing.Size(115, 30);
            generuj.Text = "Generuj hasło";
            generuj.Click += new System.EventHandler(generuj_Click);

            specjalne.Location = new System.Drawing.Point(30, 168);
            specjalne.Text = "Znaki specjalne";

            cyfry.Location = new System.Drawing.Point(30, 127);
            cyfry.Text = "Cyfry";

            litery.Checked = true;
            litery.Location = new System.Drawing.Point(30, 86);
            litery.Text = "Małe / wielkie litery";

            znakilabel.Location = new System.Drawing.Point(27, 45);
            znakilabel.Text = "Ile znaków?";

            znaki.Location = new System.Drawing.Point(128, 42);
            znaki.Size = new System.Drawing.Size(198, 22);

            zatwierdz.BackColor = System.Drawing.Color.SteelBlue;
            zatwierdz.ForeColor = System.Drawing.Color.White;
            zatwierdz.Location = new System.Drawing.Point(280, 375);
            zatwierdz.Size = new System.Drawing.Size(245, 40);
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.Click += new System.EventHandler(zatwierdz_Click);

            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(zatwierdz);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Text = "Generowanie hasła";

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox stanowisko;
        private System.Windows.Forms.Label stanowiskolabel;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label nazwiskolabel;
        private System.Windows.Forms.Label imielabel;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.CheckBox specjalne;
        private System.Windows.Forms.CheckBox cyfry;
        private System.Windows.Forms.CheckBox litery;
        private System.Windows.Forms.Label znakilabel;
        private System.Windows.Forms.TextBox znaki;
        private System.Windows.Forms.Button zatwierdz;
    }
}
