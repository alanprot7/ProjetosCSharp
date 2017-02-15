using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apsoo
{
    class Registro
    {
        private int matricula;
        private string data;
        private string entrada;
        private string saida;

        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public string Entrada
        {
            get
            {
                return entrada;
            }
            set
            {
                entrada = value;
            }
        }

        public string Saida
        {
            get
            {
                return saida;
            }
            set
            {
                saida = value;
            }
        }
    }
}
