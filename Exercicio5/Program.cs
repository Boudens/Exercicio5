using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemMenu sucoLaranja = new Bebida("Suco de Laranja", 3, 5, 8);
            ItemMenu refrigerante = new Bebida("Refrigerante", 4, 6, 10);
            ItemMenu cafe = new Bebida("Café", 1.5f, 3, 5);
            ItemMenu coxinha = new Aperitivo("Coxinha", 4);
            ItemMenu paoDeQueijo = new Aperitivo("Pão de Queijo", 2.5f);

            ItemMenu[] cardapio = { sucoLaranja, refrigerante, cafe , coxinha , paoDeQueijo,};

            foreach (ItemMenu item in cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("-------------");
                Console.ReadLine();
            }
        }
    }
}
