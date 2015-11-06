﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.CatCod = 0;
            this.ScatNome = "";
            this.ScatCod = 0;
        }


        public ModeloSubCategoria(int scatcod, int catcod, String snome)
        {
            this.ScatCod = scatcod;
            this.CatCod = catcod;
            this.ScatNome = snome;
            
        }


        private int scat_cod;

        public int ScatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }

        private int cat_cod;

        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        


        private string scat_nome;

        public string ScatNome
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }

    }
}
