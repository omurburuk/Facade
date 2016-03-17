using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        TcKimlik TcSistem = new TcKimlik();
        Sistem1Kontrol SistemKont = new Sistem1Kontrol();
        System2Operasyon SO = new System2Operasyon();

        public void System2UyeEkle(int tc)
        {
            if(TcSistem.TcKimlikKontrol(tc)&& !SistemKont.KaraListeKontrol(tc))
            {
                SO.UyeEkle(tc);
            }
           
        }
    }
}
