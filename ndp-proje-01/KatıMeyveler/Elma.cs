using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    class Elma : KatiMeyve
    {
        public Elma(string resim) : base(resim)
        {
            vitaminA = 50;
            vitaminC = 5;
        }
    }
}
