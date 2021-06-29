using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    interface ISikacak
    {
        int HesaplaGramSon();
        double HesaplaVitaminA();
        double HesaplaVitaminC();
        void meyveEkle(Meyve meyve);
    }
}
