using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_01
{
    public partial class Form1 : Form
    {
        private List<Meyve> _Meyveler;
        private Meyve _rastgeleMeyve;

        private Portakal _portakal;
        private Mandalina _mandalina;
        private Greyfurt _greyfurt;
        private Elma _elma;
        private Armut _armut;
        private Cilek _cilek;

        private KatiMeyveSikacagi _katiSikacak;
        private NarenciyeMeyveSikacagi _narenciyeSikacak;

        public Form1()
        {
            InitializeComponent();
        }

        private void YeniOyunBaslat()
        {
        
            _portakal = new Portakal(Application.StartupPath+"/resimler/" + "portakal.jpg");
            _greyfurt = new Greyfurt(Application.StartupPath + "/resimler/" + "greyfurt.jpg");
            _mandalina = new Mandalina(Application.StartupPath + "/resimler/" + "mandalina.png");
            _elma = new Elma(Application.StartupPath + "/resimler/" + "elma.jpg");
            _armut = new Armut(Application.StartupPath + "/resimler/" + "armut.jpg");
            _cilek = new Cilek(Application.StartupPath + "/resimler/" + "cilek.jpg");

            _katiSikacak = new KatiMeyveSikacagi();
            _narenciyeSikacak = new NarenciyeMeyveSikacagi();

            lblOyunSuresi.Text = "60";
            lblGram.Text = "0";
            lblGramSon.Text = "0";
            lblVitaminA.Text = "0";
            lblVitaminC.Text = "0";
           

            btnBaslat.Enabled = false;
            btnKati.Enabled = true;
            btnNarenciye.Enabled = true;
            btnBitis.Enabled = true;

            MeyveListesiOlustur();
            MeyveGoster();

            kalanSure.Enabled = true;

        }
        private void OyunBitti()
        {
            kalanSure.Enabled = false;
            picMeyveResim.InitialImage = null;
            btnKati.Enabled = false;
            btnNarenciye.Enabled = false;

            btnBitis.Enabled = false;
            btnBaslat.Enabled = true;
        }


        private void MeyveListesiOlustur()
        {
            _Meyveler = new List<Meyve>();
            _Meyveler.Add(_elma);
            _Meyveler.Add(_cilek);
            _Meyveler.Add(_armut);
            _Meyveler.Add(_greyfurt);
            _Meyveler.Add(_portakal);
            _Meyveler.Add(_mandalina);
        }

        private void MeyveGoster()
        {
            Random rnd = new Random();
            int secilen = rnd.Next(0, 6);
            _rastgeleMeyve = _Meyveler[secilen];
            picMeyveResim.Image = _rastgeleMeyve.meyveResim();
        }
      
        private void ZamaniYaz(int saniye)
        {
            int zaman = int.Parse(lblOyunSuresi.Text) + saniye;

            if (zaman == 0)
                OyunBitti();

            lblOyunSuresi.Text = zaman.ToString();
        }
        private void kalanSure_Tick(object sender, EventArgs e)
        {
            ZamaniYaz(-1);
        }
       
        private void btnNarenciye_Click(object sender, EventArgs e)
        {
            if (_rastgeleMeyve.GetType().BaseType.ToString() == "ndp_proje_01.NarenciyeMeyve")
            {
                _narenciyeSikacak.meyveEkle(_rastgeleMeyve);

                int toplamGram = int.Parse(lblGram.Text) + _rastgeleMeyve.meyveGram();
                lblGram.Text = toplamGram.ToString();
          
                int toplamGramSon = int.Parse(lblGramSon.Text) + _narenciyeSikacak.HesaplaGramSon();
                lblGramSon.Text = toplamGramSon.ToString();

                double toplamVitaminA = Double.Parse(lblVitaminA.Text) + _narenciyeSikacak.HesaplaVitaminA();
                lblVitaminA.Text = toplamVitaminA.ToString();

                double toplamVitaminC = Double.Parse(lblVitaminC.Text) + _narenciyeSikacak.HesaplaVitaminC();
                lblVitaminC.Text = toplamVitaminC.ToString();

                MeyveListesiOlustur();
                MeyveGoster();
            }
        }
        private void btnKati_Click(object sender, EventArgs e)
        {
            if (_rastgeleMeyve.GetType().BaseType.ToString() == "ndp_proje_01.KatiMeyve")
            {
                _katiSikacak.meyveEkle(_rastgeleMeyve);

                int toplamGram = int.Parse(lblGram.Text) + _rastgeleMeyve.meyveGram();
                lblGram.Text = toplamGram.ToString();

                int toplamGramSon = int.Parse(lblGramSon.Text) + _katiSikacak.HesaplaGramSon();
                lblGramSon.Text = toplamGramSon.ToString();

                double toplamVitaminA = Double.Parse(lblVitaminA.Text) + _katiSikacak.HesaplaVitaminA();
                lblVitaminA.Text = toplamVitaminA.ToString();

                double toplamVitaminC = Double.Parse(lblVitaminC.Text) + _katiSikacak.HesaplaVitaminC();
                lblVitaminC.Text = toplamVitaminC.ToString();


                MeyveListesiOlustur();
                MeyveGoster();
            }
        }


        private void btnBaslat_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void btnBitis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
