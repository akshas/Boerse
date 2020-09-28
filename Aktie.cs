using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Boerse
{
    class Aktie : INotifyPropertyChanged
    {
        public int Id { get; set; } 
        private static int AktienCounter = 0;
        public string Name { get; set; }
        public int Anzahl { get; set; }
        public double StartPreis { get; set; }
        private static Random rand = new Random();
        public static bool steigt = true;
        public static ObservableCollection<Aktie> Aktien = new ObservableCollection<Aktie>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Aktie(string name, int anzahl, double preis)
        {
            AktienCounter++;
            Id = AktienCounter;
            Name = name;
            Anzahl = anzahl;
            StartPreis = preis;
        }

        public static void changePrice()
        {
            while (true) 
            {
                Thread.Sleep(2000);

                foreach (Aktie a in Aktien)
                {
                    int randInt = rand.Next(1, 4);
                    int randBool = rand.Next(0, 2);

                    if (randBool == 1)
                        steigt = true;
                    else
                        steigt = false;



                    if (steigt)
                    {
                        a.StartPreis += randInt;
                    }
                    else
                        a.StartPreis -= randInt;

                    a.OnPropertyChanged(nameof(a.StartPreis));


                }

            }
        }

        public static ObservableCollection<Aktie> getAktien()
        {
            Aktien.Add(new Aktie("Firma1", 1000, 27));
            Aktien.Add(new Aktie("Firma2", 1100, 24));
            Aktien.Add(new Aktie("Firma3", 560, 222));
            Aktien.Add(new Aktie("Firma4", 2300, 416));
            Aktien.Add(new Aktie("Firma5", 1400, 215));
            Aktien.Add(new Aktie("Firma6", 950, 113));
            return Aktien;
        }


        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }


}
