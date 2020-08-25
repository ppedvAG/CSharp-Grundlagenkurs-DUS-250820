using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_Lab_Fuhrpark
{
    public class Transportmittel
    {
        // types
        public enum Zustand { aus, an }

        // props
        public string Name { get; set; }
        public uint MaximalGeschwindigkeit { get; }
        public double Preis { get; set; }
        public uint AktuelleGeschwindigkeit { get; private set; }
        public Zustand FZustand { get; private set; }

        // ctor
        public Transportmittel(string name, double preis, uint maximalGeschwindigkeit)
        {
            Name = name;
            Preis = preis;
            MaximalGeschwindigkeit = maximalGeschwindigkeit;
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        // methods
        public uint Beschleunige(uint erhöhung)
        {
            uint möglicheErhöhung = MaximalGeschwindigkeit - AktuelleGeschwindigkeit;
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && FZustand == Zustand.an && erhöhung <= möglicheErhöhung)
                AktuelleGeschwindigkeit += erhöhung;
            else
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;
            Console.WriteLine("Beschleunigen von Transportmittel");
            return AktuelleGeschwindigkeit;
        }

        public void StarteMotor()
        {
            FZustand = Zustand.an;
        }

        public void StoppeMotor()
        {
            FZustand = Zustand.aus;
        }

        public virtual string BeschreibeMich()
        {
            return $@"
{Name}, ({Preis} €)
Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h
Zustand: {FZustand}
Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }
    }
}
