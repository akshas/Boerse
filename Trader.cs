using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Boerse
{
    class Trader
    {

        public string Name { get; set; }
        public int TraderID { get; set; }
        private double Kapital { get; set; }

        public static ObservableCollection<Aktie> MeineAktien = new ObservableCollection<Aktie>();


        public static void Kaufen(int anzahl, Aktie aktie)
        {
            MeineAktien.Add(aktie);
            MessageBox.Show($"{aktie.Name}: {aktie.Anzahl} Stück");
        }

        public static void Verkaufen(int anzahl, Aktie aktie)
        {
            MeineAktien.Remove(aktie);
            MessageBox.Show($"{aktie.Name}: {aktie.Anzahl} Stück");
        }

        public static ObservableCollection<Aktie> getMeineAktien()
        {
                return MeineAktien;
        }
    }
}
