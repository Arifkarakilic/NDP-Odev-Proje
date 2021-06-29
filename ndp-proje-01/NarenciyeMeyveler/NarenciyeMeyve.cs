using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ndp_proje_01
{
    class NarenciyeMeyve : Meyve
    {
        private double _vitaminA;
        private double _vitaminC;
        private int _verim;
        private int _gram;


        public NarenciyeMeyve(string resimUrl) : base(resimUrl)
        {

            Random r = new Random();
            _verim = r.Next(30, 71);
        }
        public int verim { get => _verim; set => _verim = value; }
        public int gram { get => _gram; set => _gram = value; }


        public double vitaminA { get => _vitaminA; set => _vitaminA = value; }
        public double vitaminC { get => _vitaminC; set => _vitaminC = value; }
  

    }
}
