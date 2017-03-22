using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaficBeertija.Logic
{
   public class KorisnikLogic
    {
        
        public void DohvatiImeKafic()
        {
            using (var db = new KaficDB())
            {
                var upit = from k in db.Kafic select k;
                foreach (var k in upit.ToList<Kafic>())
                {
                    StaticVarijable.imeKafica = k.Ime;
                }

            }
        }
    }
}
