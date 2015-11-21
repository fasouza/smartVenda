using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItemVenda
    {
        public ModeloItemVenda()
        {
            this.ItemVendaCod = 0;
            this.ItemVendaQtd = 0;
            this.ItemVendaValor = 0;
            this.VenCod = 0;
            this.ProCod = 0;

        }


        public ModeloItemVenda(int itemvenda_cod, float itemvenda_qtd, decimal itemvenda_valor, int ven_cod, int pro_cod)
        {
            this.ItemVendaCod = itemvenda_cod;
            this.ItemVendaQtd = itemvenda_qtd;
            this.ItemVendaValor = itemvenda_valor;
            this.VenCod = ven_cod;
            this.ProCod = pro_cod;

        }

        private int itemvenda_cod;

        public int ItemVendaCod
        {
            get { return itemvenda_cod; }
            set { itemvenda_cod = value; }
        }
        private float itemvenda_qtd;

        public float ItemVendaQtd
        {
            get { return itemvenda_qtd; }
            set { itemvenda_qtd = value; }
        }
        private decimal itemvenda_valor;

        public decimal ItemVendaValor
        {
            get { return itemvenda_valor; }
            set { itemvenda_valor = value; }
        }
        private int ven_cod;

        public int VenCod
        {
            get { return ven_cod; }
            set { ven_cod = value; }
        }
        private int pro_cod;

        public int ProCod
        {
            get { return pro_cod; }
            set { pro_cod = value; }
        }



    }
}
