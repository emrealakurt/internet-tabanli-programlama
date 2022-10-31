using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _21._10._2022
{
    class Personel : Kisi
    {
        public int personelNo;
        public int maas;
        public int izinHakkı;
        public void avansAl(int avansMiktari)
        {
            if (avansMiktari< maas)
                 maas = maas - avansMiktari;
        }

    public void izinAl(int izinMiktari)
        {
            if (izinMiktari <= izinHakkı)
                izinHakkı = izinHakkı - izinMiktari;
        }


    }
}
