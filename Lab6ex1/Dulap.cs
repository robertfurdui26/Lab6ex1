using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6ex1
{
    internal class Dulap
    {
        public int inaltime;
        public int latime;
        public int lungime;

        public int CalculeazaVolum()
        {
            return inaltime * latime * lungime;
        }

        public Dulap(int inaltime,int latime,int lungime)
        {
            this.inaltime = inaltime;
            this.latime = latime;
            this.lungime = lungime;
        }
    }
}
