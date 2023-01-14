using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi.Banka
{
    public interface ITransfer :IBankaHesap //implement yapılmadı çünkü ikiside interface türünde.
    {
        //kalıtım yolu ile alma 

        bool transferYap (IBankaHesap alıcıHesap,decimal miktar);
    }
}
