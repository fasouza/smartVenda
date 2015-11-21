using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        public ModeloVenda()
        {
            this.VenCod         = 0;
            this.VenData        = Convert.ToDateTime("");
            this.VenNfiscal     = 0;
            this.VenTotal       = 0;
            this.VenParcelas    = 0;
            this.VenStatus      = "";
            this.CliCod         = 0;
            this.TpaCod         = 0;

        }
        public ModeloVenda( int ven_cod, DateTime ven_data, int ven_nfiscal, decimal ven_total, int ven_nparcelas,
                              string ven_status, int cli_cod, int tpa_cod)
        {
            this.VenCod = ven_cod;
            this.VenData = ven_data;
            this.VenNfiscal = ven_nfiscal;
            this.VenTotal = ven_total;
            this.VenParcelas = ven_nparcelas;
            this.VenStatus = ven_status;
            this.CliCod = cli_cod;
            this.TpaCod = tpa_cod;

        }


        private int ven_cod;
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        private DateTime ven_data;
        public DateTime VenData
        {
            get { return this.ven_data; }
            set { this.ven_data = value; }
        }

        private int ven_nfiscal;
        public int VenNfiscal
        {
            get { return this.ven_nfiscal; }
            set { this.ven_nfiscal = value; }
        }

        private decimal ven_total;
        public decimal VenTotal
        {
            get { return this.ven_total; }
            set { this.ven_total = value; }
        }

        private int ven_nparcelas;
        public int VenParcelas
        {
            get { return this.ven_nparcelas; }
            set { this.ven_nparcelas = value; }
        }

        private string ven_status;
        public string VenStatus
        {
            get { return this.ven_status; }
            set { this.ven_status = value; }
        }

        private int cli_cod;
        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private int tpa_cod;
        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

    }
}
