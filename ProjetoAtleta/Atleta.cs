using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private int peso;
        private int idade;


        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preechindo.");
                }
            }
            get { return this.nome; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1.00m.");
                }
            }
            get { return this.altura; }

        }



        public int Peso
        {
            set
            {
                if (value >= 10)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O Peso mínimo é 10 Kg ");
                }
            }
            get { return this.peso; }

        }


        public int Idade
        {
            set
            {
                if (value >= 2)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade minima é de 2 anos");
                }
            }
            get { return this.idade; }

        }


    }
}
