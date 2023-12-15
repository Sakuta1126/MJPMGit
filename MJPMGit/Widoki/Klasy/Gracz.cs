﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MJPMGit.Widoki.Klasy
{
    public class Gracz
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email {  get; set; }
        public string Kod {  get; set; }
        public Gracz( int id, string imie, string nazwisko, string email, string kod)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Kod = kod;
        }
        public Gracz( string imie, string nazwisko, string email, string kod)
        {
            
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Kod = kod;
        }
        public Gracz()
        {

           
        }
    }
}
