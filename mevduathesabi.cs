using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi.Banka
{
    internal class mevduatHesabi : IBankaHesap
    {
        private decimal bakiye; // field tanımı işlem yapılabilecek.
        public decimal Bakiye => bakiye;

        public bool Cek(decimal miktar)
        {
           if (bakiye>=miktar)
            {
                bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a Bakiye yetersizdir.");
            return false;
        }

        public void Yatir(decimal miktar)=> bakiye += miktar;

        public override string? ToString() =>
            $"mevduat hesabı bakiye bilgisi: {bakiye}";        
    }
}
