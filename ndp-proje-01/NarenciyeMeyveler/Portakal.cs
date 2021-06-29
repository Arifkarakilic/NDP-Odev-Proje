using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_01
{
    class Portakal : NarenciyeMeyve
    {
        public Portakal(string resim) : base(resim)
        {
            vitaminA = 225;
            vitaminC = 45;
        }
    }
}
