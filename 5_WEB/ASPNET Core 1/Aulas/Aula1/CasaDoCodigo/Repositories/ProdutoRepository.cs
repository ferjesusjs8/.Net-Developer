﻿using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void SaveProdutos(List<Livro> livros)
        {
            livros.ForEach(livro => contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco)));

            contexto.SaveChanges();
        }
    }
}