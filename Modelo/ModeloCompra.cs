using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCompra
    {
        public ModeloCompra()
        {
            this.ComCod         = 0;
            this.ComData        = "";
            this.ComNfiscal     = 0;
            this.ComTotal       = 0;
            this.ComParcelas    = 0;
            this.ComStatus      = "";
            this.ForCod         = 0;
            this.TpaCod         = 0;

        }
        public ModeloCompra( int com_cod, string com_data, int com_nfiscal, decimal com_total, int com_nparcelas,
                              string com_status, int for_cod, int tpa_cod)
        {
            this.ComCod = com_cod;
            this.ComData = com_data;
            this.ComNfiscal = com_nfiscal;
            this.ComTotal = com_total;
            this.ComParcelas = com_nparcelas;
            this.ComStatus = com_status;
            this.ForCod = for_cod;
            this.TpaCod = tpa_cod;

        }




        private int com_cod;
        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }

        private string com_data;
        public string ComData
        {
            get { return this.com_data; }
            set { this.com_data = value; }
        }

        private int com_nfiscal;
        public int ComNfiscal
        {
            get { return this.com_nfiscal; }
            set { this.com_nfiscal = value; }
        }

        private decimal com_total;
        public decimal ComTotal
        {
            get { return this.com_total; }
            set { this.com_total = value; }
        }

        private int com_nparcelas;
        public int ComParcelas
        {
            get { return this.com_nparcelas; }
            set { this.com_nparcelas = value; }
        }

        private string com_status;
        public string ComStatus
        {
            get { return this.com_status; }
            set { this.com_status = value; }
        }

        private int for_cod;
        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private int tpa_cod;
        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

    }
}
