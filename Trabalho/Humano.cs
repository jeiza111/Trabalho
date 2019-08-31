using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Humano: Mamifero
    {
        public Humano(int idade, string som, float velocidade, float peso, string cpf)
        {
            Idade = idade;
            Peso = peso;
            Som = som;
            CPF = cpf;
            Velocidade = velocidade;
        }
        

        private String CPF;
    public void Sorri ()
        {
            Console.WriteLine("Sorria");
        }
    }
    }


