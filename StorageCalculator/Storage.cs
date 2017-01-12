using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageCalculator
{
    
    public class Storage
    {
        private string id;
        private string nombre;
        private int capacidad_ocupada;
        private int capacidad_total;
        private int largo;
        private int ancho;

        public Storage(string id, string nombre, int capacidad_ocupada, int capacidad_total, int largo, int ancho)
        {
            this.id = id;
            this.nombre = nombre;
            this.capacidad_ocupada = capacidad_ocupada;
            this.capacidad_total = capacidad_total;
            this.largo = largo;
            this.ancho = ancho;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Capacidad_ocupada
        {
            get { return capacidad_ocupada; }
            set { capacidad_ocupada = value; }
        }

        public int Capacidad_total
        {
            get { return capacidad_total; }
            set { capacidad_total = value; }
        }

        public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }

        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
    }
}
