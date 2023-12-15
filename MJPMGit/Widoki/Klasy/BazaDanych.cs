using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MJPMGit.Widoki.Klasy
{
    public class BazaDanych
    {
        private readonly SQLiteConnection polaczenie;
        public BazaDanych(string sciezka)
        {
            polaczenie = new SQLiteConnection(sciezka);
            polaczenie.CreateTable<Gracz>();
            polaczenie.CreateTable<Wynik>();
        }
        public int Zapisz<T>(T obiekt)
        {
            return polaczenie.Insert(obiekt);
        }
        public List<T> Wypisz<T>() where T : new()
        {
            return polaczenie.Table<T>().ToList();
        }
    }
}
