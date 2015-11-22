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
            this.VenCod = 0;
            this.VenData = new DateTime();
            this.VenNfiscal = 0;
            this.VenTotal = 0;
            this.VenNparcelas = 0;
            this.VenStatus = "";
            this.CliCod = 0;
            this.TpaCod = 0;
        }

        public ModeloVenda(int ven_cod, DateTime ven_data, int ven_nfiscal, double ven_total, int ven_nparcelas, String ven_status,
            int cli_cod, int tpa_cod)
        {
            this.VenCod = ven_cod;
            this.VenData = ven_data;
            this.VenNfiscal = ven_nfiscal;
            this.VenTotal = ven_total;
            this.VenNparcelas = ven_nparcelas;
            this.VenStatus = ven_status;
            this.CliCod = cli_cod;
            this.TpaCod = tpa_cod;
        }

        private int _ven_cod;
        public int VenCod
        {
            get
            {
                return this._ven_cod;
            }
            set
            {
                this._ven_cod = value;
            }
        }

        private DateTime _ven_data;
        public DateTime VenData
        {
            get
            {
                return this._ven_data;
            }
            set
            {
                this._ven_data = value;
            }
        }

        private int _ven_nfiscal;
        public int VenNfiscal
        {
            get
            {
                return this._ven_nfiscal;
            }
            set
            {
                this._ven_nfiscal = value;
            }
        }

        private double _ven_total;
        public double VenTotal
        {
            get
            {
                return this._ven_total;
            }
            set
            {
                this._ven_total = value;
            }
        }

        private int _ven_nparcelas;
        public int VenNparcelas
        {
            get
            {
                return this._ven_nparcelas;
            }
            set
            {
                this._ven_nparcelas = value;
            }
        }

        private String _ven_status;
        public String VenStatus
        {
            get
            {
                return this._ven_status;
            }
            set
            {
                this._ven_status = value;
            }
        }

        private int _cli_cod;
        public int CliCod
        {
            get
            {
                return this._cli_cod;
            }
            set
            {
                this._cli_cod = value;
            }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get
            {
                return this._tpa_cod;
            }
            set
            {
                this._tpa_cod = value;
            }
        }
    }
}
