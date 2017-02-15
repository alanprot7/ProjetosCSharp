using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NfsEmitir
{
    class Certidao
    {
        private string nome;
        private double custasTotal;
        private double custasDeducao;
        private string descricao;

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return this.descricao;
        }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setCustasTotal(double valor)
        {
            this.custasTotal = valor;
        }

        public double getCustasTotal()
        {
            return this.custasTotal;
        }

        public void setCustasDeducao(double valor)
        {
            this.custasDeducao = valor;
        }

        public double getCustasDeducao()
        {
            return this.custasDeducao;
        }
    }
}
