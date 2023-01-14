using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi.Banka
{
    public class yatirimHesabi : IBankaHesap
    {

        private decimal bakiye; // field tanımı işlem yapılabilecek.
        public decimal Bakiye => bakiye;// mevcut bakiye ne ise güncellemiş oluyoruz.

        public bool Cek(decimal miktar)
        {
            if (bakiye >= miktar)
            {
                bakiye -= miktar;
                return true;
            }
            Console.WriteLine("Yatırım hesabınızda bakiye yetersizdir yeniden deneyiniz.");
            return false;
        }

        public void Yatir(decimal miktar) =>
            bakiye += miktar;

        public override string? ToString() =>
            $" yatırım hesabı bakiye Bilgisi: {bakiye}";

    }
}
