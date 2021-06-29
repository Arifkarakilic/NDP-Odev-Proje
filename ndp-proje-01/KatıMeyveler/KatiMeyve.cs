using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ndp_proje_01
{
    class KatiMeyve : Meyve
    {
        private int _verim;
        private int _gram;
        private double _vitaminA;
        private double _vitaminC;


        public KatiMeyve(string resimUrl) : base(resimUrl)
        {
            Random r = new Random();
            _verim = r.Next(80, 96);
        }

        public int verim { get => _verim; set => _verim = value; }
        public int gram { get => _gram; set => _gram = value; }
        public double vitaminA { get => _vitaminA; set => _vitaminA = value; }
        public double vitaminC { get => _vitaminC; set => _vitaminC = value; }
     
    }
}
