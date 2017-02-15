using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NfsEmitir
{
    class Protocolo
    {
        private string numero;
        private double valor;
        private string descrição;
        private double custaTotal;
        private double custaDeducao;

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor() 
        {
            return this.valor;
        }

        public void setDescricao(string descricao)
        {
            this.descrição = descricao;
        }

        public string getDescricao()
        {
            return this.descrição;
        }

        public void setCustaTotal(double valor)
        {
            this.custaTotal = valor;
        }

        public double getCustaTotal()
        {
            return this.custaTotal;
        }

        public void setCustaDeducao(double valor)
        {
            this.custaDeducao = valor;
        }

        public double getCustaDeducao()
        {
            return this.custaDeducao;
        }

    }
}
