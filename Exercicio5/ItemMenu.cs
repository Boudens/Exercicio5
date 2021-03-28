using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class ItemMenu
    {
        public ItemMenu(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; protected set; }

        public virtual void ImprimirNome()
        {
            Console.WriteLine($"Nome do item: {nome}");
        }

        public virtual void ImprimirPreco()
        {
            Console.WriteLine("Preço do produto indefinido");
        }

        }
    }
