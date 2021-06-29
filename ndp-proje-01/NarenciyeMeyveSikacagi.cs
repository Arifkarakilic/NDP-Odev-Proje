using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    class NarenciyeMeyveSikacagi : ISikacak
    {
        private NarenciyeMeyve meyve;
        public void meyveEkle(Meyve meyve)
        {
            this.meyve = (NarenciyeMeyve)meyve;
        }
        public int HesaplaGramSon()
        {
            return (meyve.meyveGram() * meyve.verim) / 100;

        }
        public double HesaplaVitaminA()
        {
            return (HesaplaGramSon() * meyve.vitaminA) / 100000;
        }

        public double HesaplaVitaminC()
        {
            return (HesaplaGramSon() * meyve.vitaminC) / 100000;
        }

      
    }
}
