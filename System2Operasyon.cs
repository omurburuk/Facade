using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class System2Operasyon
    {
        Sistem1Kontrol s1 = new Sistem1Kontrol();

        public void UyeEkle(int i)
        {
            
            Console.WriteLine("Üye Eklendi");
        }
    }
}
