using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaRetorno
{
    class Desistencia
    {
        private string protocolo;
        private string dia;

        public string getProtocolo()
        {
            return protocolo;
        }

        public void setProtocolo(string protocolo)
        {
            this.protocolo = protocolo;
        }

        public string getDia()
        {
            return dia;
        }

        public void setDia(string dia)
        {
            this.dia = dia;
        }
    }
}
