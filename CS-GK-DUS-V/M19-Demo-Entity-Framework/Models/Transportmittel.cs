using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M19_Demo_Entity_Framework.Models
{
    public class Transportmittel
    {
        public enum Zustand { aus, an }

        // props
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public uint MaximalGeschwindigkeit { get; set; }
        [Required]
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
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit)
            {
                if (FZustand == Zustand.an)
                {
                    if (erhöhung <= möglicheErhöhung)
                    {
                        AktuelleGeschwindigkeit += erhöhung;
                    }

                }
            }
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
