using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCredito
{
    public class UsuarioInformation
    {

        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nome;

        public string Nome
        {
            get {return _nome; }
            set {_nome = value; }
        }

        private string _senha;

        public string Senha
        {
            get {return _senha; }
            set {_senha = value; }
        }

        private string _nivel;

        public string Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
    }
}
