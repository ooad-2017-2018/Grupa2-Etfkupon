using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class FirmaPocetnaModelView
    {

        public void PromijeniPassword(string password)
        {
            Validacija v = new Validacija();
            //Treba implenetirati radnju Promijeni sifru kod PocetnaFirme.xaml
           /* if(v.ValidirajPasswordFirme()==new Tuple<int, string>(0, "Validno"))
                MainPage.etfKupon.ListaFirmi.Find(x=> x.Username==MainPage.TrenutnaFirma.Username).Password=password;*/
            //else
            //  reci razlog zasto nece
            //
        }
    }
}
