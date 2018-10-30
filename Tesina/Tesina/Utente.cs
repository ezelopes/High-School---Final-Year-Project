using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesina
{
    class Utente
    {
        private string nome, password;
        private int punteggio;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Punteggio
        {
            get { return punteggio; }
            set { punteggio = value; }
        }
    }
}
