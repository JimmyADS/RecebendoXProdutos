﻿using System.Globalization;

namespace Produto.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoTag()
        {
            return Nome
                + "$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
