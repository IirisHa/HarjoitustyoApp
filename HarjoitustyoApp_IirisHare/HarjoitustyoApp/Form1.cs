using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarjoitustyoApp
{
    public partial class FrmHarjoitustyo : Form
    {
        public List<Henkilo> henkilot = new List<Henkilo>();
        public string[] hetunTarkistus = { "0","1","2", "3","4","5","6","7","8","9", "A", "B", 
        "C", "D", "E", "F", "H", "J", "K", "L", "M", "N", "P", "R", "S", "T", "U", "V", "W", "X", "Y" };

        public string file = "Henkilot.json";

        public bool tiedotTallennettu = true;
        public void SerializeJSON(List<Henkilo> input)
        {
            input = input.OrderBy(x => x.Sukunimi).ToList();
            foreach (var henkilo in input)
            {
                if (henkilo.Toimisuhteet == null)
                {
                    henkilo.Toimisuhteet = new List<Toimisuhde>();
                }
            }
            string json = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(file, json);
        }
        public List<Henkilo> DeserializeJSON()
        {
            if (File.Exists(file))
            {
                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Henkilo>>(json);
                }
            }
            else
                return null;
        }

        
        public void LisaaHenkilo()
        {
            Henkilo h = new Henkilo();
            h.Etunimet = tbEtunimet.Text;
            h.Kutsumanimi = tbKutsumanimi.Text;
            h.Sukunimi = tbSukunimi.Text;
            h.Hetu = tbHetu.Text;
            h.Katuosoite = tbKatuosoite.Text;
            h.Postinumero = tbPostinumero.Text;
            h.Postitoimipaikka = tbPostitoimipaikka.Text;

            Toimisuhde t = new Toimisuhde();
            t.Alkamispaiva = dtpAlkamispaiva.Value;
            t.Paattymispaiva = dtpPaattymispaiva.Value;
            t.Tyonimike = tbTyonimike.Text;
            t.Yksikko = tbYksikko.Text;

            if (h.Toimisuhteet == null)
            {
                h.Toimisuhteet = new List<Toimisuhde>();
            }

            h.Toimisuhteet.Add(t);
            henkilot.Add(h);

            dgvTiedot.DataSource = null;
            dgvTiedot.DataSource = henkilot;

            tiedotTallennettu = false;
        }



        public void lokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("lokitiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }


        /*Tässä tarkistetaan henkilötunnus: onko yhteensä 11 merkkiä, numero-osan jälkeen tulee +,- tai A,
         kolme seuraavaa merkkiä oltava väliltä 002-899 ja viimeisen merkin oikeellisuus tarkistetaan sen 
         sen jakojäännöksen avulla. Apuna käytetään globaalia hetunTarkistus-taulukkoa, johon on syötetty 
         jakojäännöstä vastaavat merkit.*/
        public bool henkilotunnuksenTarkistus(string Hetu)
        {

            int i;

            Hetu = Hetu.Trim();
            if (Hetu.Length != 11)
            {

                return false;
            }

            if (Hetu[6] != '+' && Hetu[6] != '-' && Hetu[6] != 'A')
            {

                return false;
            }

            for (i = 0; i < 6; i++)
            {

                if (!char.IsDigit(Hetu[i]))
                {
                    return false;
                }
            }

           
            string loppu = Hetu.Substring(7, 3);
            int iLoppu = int.Parse(loppu);

            if (iLoppu < 2 && Hetu[i] > 899)
            {
                return false;
            }

          
            string alku = Hetu.Substring(0, 6);
            int iAlku = int.Parse(alku);

            string kokoNumero = alku + loppu; 
            int ikokoNumero = int.Parse(kokoNumero);
            int jakojaannos = ikokoNumero % 31;
            char Tarkistusmerkki = char.Parse(Hetu.Substring(10, 1));

           
            if (hetunTarkistus[jakojaannos] == Tarkistusmerkki.ToString()) 
            {

                return true;
            }
            else 
            {
                return false;
            }
        }

        public FrmHarjoitustyo()
        {
            InitializeComponent();
            henkilot = DeserializeJSON();
            if ( henkilot == null )
            {
                henkilot = new List<Henkilo>();
            }
            dgvTiedot.DataSource = henkilot;
            lokiinTallentaminen("sovellus käynnistettiin, käyttäjä: ");

        }
        //Korjataan molemmat etunimet alkamaan isolla kirjaimella
        private void tbEtunimet_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                string[] nimet = nimi.Split(' ');

                for (int i = 0; i < nimet.Length; i++)
                {
                    if (nimet[i].Length > 0)
                    {
                        nimet[i] = nimet[i].Substring(0, 1).ToUpper() + nimet[i].Substring(1).ToLower();
                    }
                }

                nimi = string.Join(" ", nimet);
                tb.Text = nimi;
            }
        }

        //Tässä korjataan etunimen tai postiosoitteen eka kirjain isoksi
        private void tbEtunimi_Leave(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }

        }
       

        private void btnLisaa_Click(object sender, EventArgs e)
        { 
            LisaaHenkilo();
            dgvTiedot.DataSource = null;
            dgvTiedot.DataSource = henkilot;

            tiedotTallennettu = false;
        }


        private void tsTallenna_Click(object sender, EventArgs e)
        {
            SerializeJSON(henkilot);
            tiedotTallennettu = true;
            lokiinTallentaminen("Tiedot tallennettiin, käyttäjä: "); 
        }

        private void tsLopeta_Click(object sender, EventArgs e)
        {
            if (!tiedotTallennettu)
            {
                if (DialogResult.OK == MessageBox.Show("Tiedot tallentamatta. Haluatko silti poistua?",
                    "Varoitus", MessageBoxButtons.YesNo))
                    Application.Exit();

            }
            else if (tiedotTallennettu)
            {
                Application.Exit();
            }

        }

        //postinumeroksi voi syöttää vain lukuja:
        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Tässä suoritetaan postipaikan ennustus
        private void tbPostinumero_Leave(object sender, EventArgs e)
        {
            if (henkilot != null)
            {
                if (tbPostinumero.TextLength >= 2)
                {
                    foreach (Henkilo x in henkilot)
                    {
                        if (tbPostinumero.Text == x.Postinumero)
                        {
                            tbPostitoimipaikka.Text = x.Postitoimipaikka;
                        }
                    }
                }
            }
        }
  

        //nimeen ei voi syöttää lukuja
        private void tbEtunimet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        //poistetaan henkilön tiedot listasta
        private void btnPoista_Click(object sender, EventArgs e)
        {

            int rowindex = dgvTiedot.CurrentRow.Index;

            henkilot.RemoveAt(rowindex);

            dgvTiedot.DataSource = null;
            dgvTiedot.DataSource = henkilot;
            lokiinTallentaminen("Tiedot poistettiin, käyttäjä: "); 


        }

        //henkilötunnuksen oikeellisuuden tarkistus (funktion kutsu)
        private void tbHetu_Leave(object sender, EventArgs e)
        {

            bool ok = henkilotunnuksenTarkistus(tbHetu.Text);
            if (ok == false)
            {
                MessageBox.Show("Henkilötunnus on virheellinen");
            }

        }
        //Päättymispäivä ei saa olla tulevaisuudessa eikä aikaisempi kuin alkamispäivä
        private void dtpPaattymispaiva_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPaattymispaiva.Value > DateTime.Now)
            {
                MessageBox.Show("Päättymispäivä ei voi olla tulevaisuudessa");
            }

            if (dtpPaattymispaiva.Value < dtpAlkamispaiva.Value)
            {
                MessageBox.Show("Päättymispäivä ei voi olla ennen alkamispäivää");
            }

        }
        /*Muokkausominaisuus syötettyihin tietoihin saadaan tuplaklikkaamalla haluttua riviä.*/
            private void dgvTiedot_DoubleClick(object sender, EventArgs e)
        {
            
            int rowindex = dgvTiedot.CurrentRow.Index;

            if (rowindex >= 0 && rowindex < henkilot.Count)
            {
                Henkilo selectedHenkilo = henkilot[rowindex];

                if (selectedHenkilo != null)
                {
                    tbEtunimet.Text = selectedHenkilo.Etunimet;
                    tbKutsumanimi.Text = selectedHenkilo.Kutsumanimi;
                    tbSukunimi.Text = selectedHenkilo.Sukunimi;
                    tbHetu.Text = selectedHenkilo.Hetu;
                    tbKatuosoite.Text = selectedHenkilo.Katuosoite;
                    tbPostinumero.Text = selectedHenkilo.Postinumero;
                    tbPostitoimipaikka.Text = selectedHenkilo.Postitoimipaikka;

                    if (selectedHenkilo.Toimisuhteet != null && selectedHenkilo.Toimisuhteet.Count > 0)
                    {
                        dtpAlkamispaiva.Value = selectedHenkilo.Toimisuhteet[0].Alkamispaiva;
                        dtpPaattymispaiva.Value = selectedHenkilo.Toimisuhteet[0].Paattymispaiva;
                        tbTyonimike.Text = selectedHenkilo.Toimisuhteet[0].Tyonimike;
                        tbYksikko.Text = selectedHenkilo.Toimisuhteet[0].Yksikko;
                    }
                    else
                    {
                        MessageBox.Show("Henkilöllä ei ole toimisuhteita.");
                    }

                    dgvTiedot.Update();
                }
                
            }

        }


    }
}
