using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaPoliformismoApp
{
    public class Mascota
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public virtual void RealizarExamen()
        {
            Console.WriteLine($"Realizando chequeo general a {Nombre}");
        }
    }

    public class Perro : Mascota
    {
        public bool EsEntrenado { get; set; }

        public override void RealizarExamen()
        {
            Console.WriteLine($"[Canino] Revisando articulaciones y vacunas de {Nombre}");
        }
    }

    public class Gato : Mascota
    {
        public override void RealizarExamen()
        {
            Console.WriteLine($"[Felino] Revisando reflejos y pelaje de {Nombre}");
        }
    }
}
