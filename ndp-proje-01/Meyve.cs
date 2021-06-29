using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ndp_proje_01
{
    abstract class Meyve
    {
        protected int gram;
        protected int verim;
        protected double vitaminC;
        protected int vitaminA;
        protected Image resim;

        public Meyve(string resimUrl)
        {
            Random r = new Random();
            gram = r.Next(70, 121);

            resim = Image.FromFile(resimUrl);
        }

        public int meyveGram()
        {
            return gram;
        }
        public Image meyveResim()
        {
            return resim;
        }
        
    }

}