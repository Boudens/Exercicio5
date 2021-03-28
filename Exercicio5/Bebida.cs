using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Bebida : ItemMenu
    {
        public Bebida(string nome ,double precoPequeno, double precoMedio, double precoGrande) : base(nome)
        {
            this.precoPequeno = precoPequeno;
            this.precoMedio = precoMedio;
            this.precoGrande = precoGrande;
        }

        public double precoPequeno  { get; private set; }
        public double precoMedio { get; private set; }
        public double precoGrande { get; private set; }

        public override void ImprimirPreco()
        {
            Console.WriteLine($"No tamanho pequeno é R$ {precoPequeno}");
            Console.WriteLine($"No tamanho médio é R$ {precoMedio}");
            Console.WriteLine($"No tamanho grande é R$ {precoGrande}");
        }
    }
}
