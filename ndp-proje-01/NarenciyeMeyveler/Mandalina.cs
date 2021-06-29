using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    class Mandalina : NarenciyeMeyve
    {
        public Mandalina(string resim) : base(resim)
        {
            vitaminA = 681;
            vitaminC = 26;
        }
    }
}
