using System;
using System.Globalization;

namespace Modelo
{
    public class ModeloItemVenda
    {
        public ModeloItemVenda()
        {
            this.ItemVendaCod = 0;
            this.ItemVendaQtde = 0;
            this.ItemVendaValor = 0;
            this.VenCod = 0;
            this.ProCod = 0;
        }

        public ModeloItemVenda(int itemvendacod, double itemvendaqtde, double itemvendavalor, int vencod, int procod)
        {
            this.ItemVendaCod = itemvendacod;
            this.ItemVendaQtde = itemvendaqtde;
            this.ItemVendaValor = itemvendavalor;
            this.VenCod = vencod;
            this.ProCod = procod;
        }

        private int itemvenda_cod;
        public int ItemVendaCod
        {
            get
            {
                return this.itemvenda_cod;
            }
            set
            {
                this.itemvenda_cod = value;
            }
        }

        private double itemvenda_qtde;
        public double ItemVendaQtde
        {
            get
            {
                return this.itemvenda_qtde;
            }
            set
            {
                this.itemvenda_qtde = value;
            }
        }

        private double itemvenda_valor;
        public double ItemVendaValor
        {
            get
            {
                return this.itemvenda_valor;
            }
            set
            {
                this.itemvenda_valor = value;
            }
        }

        private int ven_cod;
        public int VenCod
        {
            get
            {
                return this.ven_cod;
            }
            set
            {
                this.ven_cod = value;
            }
        }

        private int pro_cod;
        public int ProCod
        {
            get
            {
                return this.pro_cod;
            }
            set
            {
                this.pro_cod = value;
            }
        }

        private string produto;
        public string ItemVendaProduto
        {
            get
            {
                return this.produto;
            }
            set
            {
                this.produto = value;
            }
        }

        public string ItemVendaValorString
        {
            get
            {
                return "R$ " + String.Format(CultureInfo.InvariantCulture, "{0:0.00}", this.itemvenda_valor);
            }
        }
    }
}
