using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaficBeertija.Logic
{
    public class ProvjeraBaze
    {
        public void Provjera()
        {
            using (var db = new KaficDB())
            {
                var query = (from k in db.Korisnik select k.ID_korisnik).Count();
                if (query == 0)
                {
                    StaticVarijable.bazaPrazna = true;
                }

            }


        }
    }
}
