using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaficBeertija.Logic
{
    public static class StaticVarijable
    {

        public static bool bazaPrazna = false;
        public static string imeKafica;
        public static int tipKorisnika;
   

        //narudzbenica
        public static bool narArt = false;
        public static bool odabirDobavljaca = false;

        public static Dobavljac dobavljac;
        public static BindingList<Artikl> listaArtikla = new BindingList<Artikl>();

        public static string logiranKorisnik;

        //za spremanje ID-ova
        public static int ID_kafica;
        public static int ID_dobavljaca;
        public static int ID_korisnika;
        public static int ID_narudzbencia;

        public static int test;

        //racuni
        public static double ukupanIznos;
        public static int ID_racun;
        public static float iznos;
        //narreport
        public static int iDNar;

        //statistika
        public static double PrometKrajDana=0;
        public static DateTime pocetakRada;
        
        public static int ID_korisnik;

        public static string ime;
        public static string prezime;
    }
}
