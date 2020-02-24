using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica
{
    class Cliente
    {
        public DateTime Data;
        private string Nome;
        private int Idade;

        public string nome
        {
            get { return Nome; }
            set
            {
                Nome = value;
            }
        }
        public DateTime data
        {
            get { return Data; }
            set
            {
                Data = value;
            }
        }
        public int idade
        {
            get { return Idade; }
            set
            {
                Idade = value;
            }
        }
    }
}
