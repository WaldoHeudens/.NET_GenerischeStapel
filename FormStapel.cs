using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerischeStapel
{
    public partial class FormStapel : Form
    {
        //IntegerStapel stapel = new IntegerStapel();   // Gebruik één van beide stapels
        Stapel<int> stapel = new Stapel<int>();
        Stapel<string> stringStapel = new Stapel<string>();
        Stapel<DateTime> datumStapel = new Stapel<DateTime>();
        bool gebruikerWijzigt = true;       // Wordt false als het programma zelf de waarde van udVoegToe wijzigt

        public FormStapel()
        {
            InitializeComponent();
        }

        private void udVoegToe_ValueChanged(object sender, EventArgs e)
        {
            if (gebruikerWijzigt)  // Alleen als de gebruiker de waarde heeft gewijzigd
            {
                stapel.OpStapel(Convert.ToInt32(udVoegToe.Value));
                tbShowContent.Text = stapel.ToString(); // niet in opgave:  Wel als controle
            }
        }

        private void btHaalAf_Click(object sender, EventArgs e)
        {
            gebruikerWijzigt = false;   // Deze methode zal zelf de waarde van udVoegToe wijzigen!
            int? result = stapel.VanStapel();  
            if (!result.HasValue)   // result == NULL => stapel is leeg
                MessageBox.Show("De stapel is leeg");
            else 
                udVoegToe.Value = result.Value;
            tbShowContent.Text = stapel.ToString();   // niet in opgave:  Wel als controle
            gebruikerWijzigt = true; // methode zal waarden upVoegToe niet meer wijzigen
        }

        private void tbStringToevoegen_Leave(object sender, EventArgs e)
        {
            stringStapel.OpStapel(tbStringToevoegen.Text);
            tbShowContent.Text = stringStapel.ToString(); // niet in opgave:  Wel als controle
        }

        private void btHaalStringAf_Click(object sender, EventArgs e)
        {
            tbStringToevoegen.Text = stringStapel.VanStapel();
            tbShowContent.Text = stringStapel.ToString(); // niet in opgave:  Wel als controle
        }

        private void btVoegDatumToe_Click(object sender, EventArgs e)
        {
            datumStapel.OpStapel(DateTime.Now);
            tbShowContent.Text = datumStapel.ToString(); // niet in opgave:  Wel als controle
        }

        private void btHaalDatumAf_Click(object sender, EventArgs e)
        { 
            tbToonDatum.Text = datumStapel.VanStapel().ToString();
            tbShowContent.Text = datumStapel.ToString(); // niet in opgave:  Wel als controle
        }
    }
}
