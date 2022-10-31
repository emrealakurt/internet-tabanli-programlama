using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sinema
{
    internal class Sinema
    {
        public int toplamKoltukSayisi;
        public int bosKoltukSayisi;
        public double bakiye;
        public string salonNo;
        public double tam=50;
        public double indirimli=35;

        

        public void BiletSat(bool indirim)
        {   
            if (bosKoltukSayisi > 0)
           // bosKoltukSayisi--; sadece bir azalma veya 1 artmada //
            bosKoltukSayisi = bosKoltukSayisi - 1;
            if (indirim) // sattığım bilet indirimli ise
                bakiye = bakiye + indirimli;
                //bakiye += indirimli;
            else // sattığım bilet tam ise
                bakiye = bakiye + tam;
                //bakiye += tam;
        }
        public void BiletIptal(bool indirim)
        {
            bosKoltukSayisi = bosKoltukSayisi + 1;
            if (indirim) // iptal edilen bilet indirimli ise
                bakiye = bakiye - indirimli;
            else    // iptal edilen bilet tam ise
                bakiye = bakiye - tam;
        }
        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }
        public double BakiyeOgren()
        {
            return bakiye;
        }
    }
}
