using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon
{
    public interface Iobserver
    {
        void Update(string poruka);
    }
}
