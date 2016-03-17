using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Sistem1Kontrol
    {
       public ArrayList karanumaras = new ArrayList();
        public void karalisteekle(int k)
        {
            karanumaras.Add(k);
        }
        
        public bool KaraListeKontrol(int numara)
        {
            bool kontrol = false;
            for (int i = 0; i < karanumaras.Count; i++)
            {
                if (numara == Convert.ToInt16(karanumaras[i]))
                {
                    kontrol = true;
                }
            }
            return kontrol;
        }
    }
}
