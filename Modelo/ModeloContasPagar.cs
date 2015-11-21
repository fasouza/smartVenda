using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloContasPagar
    {
        //construtor
        public ModeloContasPagar()
        {
            this.CPCod         = 0;
            this.CPDescricao        = "";
            this.CPValor = 0;
            this.CPStatus = "";
            this.CPVencimento = new DateTime(2010, 10, 10);
            this.CPPagamento = new DateTime(2010, 10, 10);
            this.CPFornecedor = 0;

        }


        public ModeloContasPagar(int cpcod, String cpdescricao, Double cpvalor, DateTime cpvencimento, DateTime cppagamento,int cpfornecedor, String cpstatus)
        {
            this.CPCod = cpcod;
            this.CPDescricao = cpdescricao;
            this.CPValor = cpvalor;
            this.CPVencimento = cpvencimento;
            this.CPPagamento = cppagamento;
            this.CPFornecedor = cpfornecedor;
            this.CPStatus = cpstatus;

        }

        //propiedades de classe

            private int CP_cod;
            public int CPCod
            {
                get { return this.CP_cod; }
                set { this.CP_cod = value; }
            }

            private DateTime CP_pagamento;
            public DateTime CPPagamento
            {
                get { return this.CP_pagamento; }
                set { this.CP_pagamento = value; }
            }
            private DateTime CP_vencimento;
            public DateTime CPVencimento
            {
                get { return this.CP_vencimento; }
                set { this.CP_vencimento = value; }
            }
            private Double CP_valor;
            public Double CPValor
            {
                get { return this.CP_valor; }
                set { this.CP_valor = value; }
            }
            private int CP_fornecedor;
            public int CPFornecedor
            {
                get { return this.CP_fornecedor; }
                set { this.CP_fornecedor = value; }
            }
            private String CP_status;
            public String CPStatus
            {
                get { return this.CP_status; }
                set { this.CP_status = value; }
            }
            private String CP_descricao;
            public String CPDescricao
            {
                get { return this.CP_descricao; }
                set { this.CP_descricao = value; }
            } 
    }
}
