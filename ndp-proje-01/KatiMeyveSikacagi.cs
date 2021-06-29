using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    class KatiMeyveSikacagi : ISikacak
    {
        private KatiMeyve meyve;

        public void meyveEkle(Meyve meyve)
        {
            this.meyve = (KatiMeyve)meyve;
        }
        public int HesaplaGramSon()
        {
            Console.WriteLine(meyve.gram);
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
