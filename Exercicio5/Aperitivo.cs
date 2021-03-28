using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome,double precoAperitivo) : base(nome)
        {
            this.precoAperitivo = precoAperitivo;
        }

        public double precoAperitivo { get; private set; }


        public override void ImprimirPreco()
        {
            Console.WriteLine($"{precoAperitivo.ToString("C")}");
        }
    }
}
