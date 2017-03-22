using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaficBeertija.Logic
{
    static partial class LoginLogic
    {
        public static int autentifikacijaKorisnika(string username, string password)
        {
            using (var db = new KaficDB())
            {
                var query = from korisnici in db.Korisnik orderby korisnici.ID_korisnik select korisnici;

                foreach (var korisnik in query.ToList<Korisnik>())
                {
                    if (korisnik.Username == username)
                    {
                        if (korisnik.Password == password)
                        {
                            return korisnik.ID_tip_korisnika;
                            
                        }
                    }
                }
                return 0;
            }
        }
    }
}
