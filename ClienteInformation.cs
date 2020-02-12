using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCredito
{

    public class ClienteInformation
    {
        
        private int _codigo_escritorio;

        public int CodigoEscritorio
        {
            get { return _codigo_escritorio; }
            set { _codigo_escritorio = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value;}
        }

        private string _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private int _protocoloER;

        public int ProtocoloER
        {
            get { return _protocoloER; }
            set { _protocoloER = value; }
        }

        private decimal _credito;

        public decimal Credito
        {
            get { return _credito; }
            set { _credito = value; }
        }


        private decimal _saldo;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
    }
}
