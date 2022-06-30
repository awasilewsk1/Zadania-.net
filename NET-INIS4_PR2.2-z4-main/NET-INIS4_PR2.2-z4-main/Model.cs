using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Model
    {
        /*Prawdopodobnie brakuje jawnego pola z listą, właściwości jawnie zaimplementowanej i notyfikacji o zmianie*/
        public LinkedList<Osoba> Lista { get; set; } = new LinkedList<Osoba>(new Osoba[] {
            new Osoba() {
                Tytuł = "Spider-man",
                Reżyser = "Stan Lee",
                Wydawca = "Story House Egmont",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("29.09.2006")
            },
            new Osoba() {
                Tytuł = "Pulp Fiction",
                Reżyser = "Quentin Tarantino",
                Wydawca = "A Band Apart Jersey Films",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("14.09.1994")
            },
            new Osoba() {
                Tytuł = "Avatar",
                Reżyser = " James Cameron",
                Wydawca = "20th Century Fox",
                Nośnik = "BluRay i DVD",
                DataNagrania = DateTime.Parse("29.12.2009")
            },
        });

        internal void OtwórzSzczegóły(Osoba wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
        internal void DodajNowy()
        {
            Osoba nowa = new Osoba();
            Lista.AddLast(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();
            /*aktualizowanie widoku samej listy*/
        }
    }
}