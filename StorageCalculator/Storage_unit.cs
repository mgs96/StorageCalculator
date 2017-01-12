﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageCalculator
{

    public class Storage_unit
    {
        private int cantidad;
        private string tipo;
        private string id;
        private int folios;
        private int mlineal;

        public Storage_unit(int cantidad, string tipo, string id, int folios, int mlineal)
        {
            this.cantidad = cantidad;
            this.tipo = tipo;
            this.id = id;
            this.folios = folios;
            this.mlineal = mlineal;
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Folios
        {
            get { return folios; }
            set { folios = value; }
        }

        public int Mlineal
        {
            get { return mlineal; }
            set { mlineal = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}