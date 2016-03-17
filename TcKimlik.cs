using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class TcKimlik
    {
        ArrayList tc = new ArrayList();
        public void TcKimlikEkle(int k)
        {
            tc.Add(k);
            Console.WriteLine("Tc Eklendi");
        }
        bool kontrol=false;
        public bool  TcKimlikKontrol(int Tc)
        {
            
            for (int i = 0; i < tc.Count; i++)
            {
               if(Convert.ToInt16(tc[i]) == Tc) {
                    kontrol = true;
                    Console.WriteLine("Tc Var");
                }
            }
            return kontrol;
        }
    }
}
