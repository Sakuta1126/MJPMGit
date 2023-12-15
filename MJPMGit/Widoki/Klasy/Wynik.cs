using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MJPMGit.Widoki.Klasy
{
    public class Wynik
    {
        [AutoIncrement, PrimaryKey] 
        public int Id { get; set; }
        public DateTime DataLosowania { get; set; }
        public string WygraneLiczby { get; set; }
        public int IloscWygranych { get; set; }

        public Wynik() { }
        public Wynik(int id, DateTime dataLosowania, string wygraneLiczby, int iloscWygranych)
        {
            Id = id;
            DataLosowania = dataLosowania;
            WygraneLiczby = wygraneLiczby;
            IloscWygranych = iloscWygranych;
        }
        public Wynik(DateTime dataLosowania, string wygraneLiczby, int iloscWygranych)
        {
            DataLosowania = dataLosowania;
            WygraneLiczby = wygraneLiczby;
            IloscWygranych = iloscWygranych;
        }
    }
}
