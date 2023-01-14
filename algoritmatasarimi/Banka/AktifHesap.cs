using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi.Banka
{
    public class AktifHesap : ITransfer
    {
        private decimal bakiye;
        public decimal Bakiye => bakiye;

        public bool Cek(decimal miktar)
        {
            if (bakiye >= miktar)
            {

                bakiye -= miktar;
                return true;
            }

            Console.WriteLine("Akrif hesabınızda paranız yetersizdir.");
            return false;
        }

        public bool transferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = Cek(miktar);
            if (sonuc==true)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }

        public void Yatir(decimal miktar)
        {
            bakiye += miktar;
        }

        public override string? ToString() =>
            $"aktif banka bakiye bilginiz: {bakiye}";
        
    }
}
