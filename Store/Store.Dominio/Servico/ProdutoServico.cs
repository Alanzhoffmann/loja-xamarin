using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;
using Store.Dominio.Interface.Servico;

namespace Store.Dominio.Servico
{
    public class ProdutoServico : ServicoEntidadeBase<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _repositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public ProdutoServico(IProdutoRepositorio repositorio, ICategoriaRepositorio categoriaRepositorio) : base(repositorio)
        {
            _repositorio = repositorio;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public override async Task<IList<Produto>> RetornarTodos(Predicate<Produto> filter = null)
        {
            IList<Produto> produtos = await base.RetornarTodos(filter);
            IList<Categoria> categorias = await _categoriaRepositorio.RetornarTodos();

            foreach (Produto produto in produtos)
            {
                Categoria categoria = categorias.FirstOrDefault(c => c.Id == produto.CategoriaId);
                if (categoria != null)
                {
                    produto.Categoria = categoria;
                }
            }

            return produtos;
        }

        public override async Task<Produto> RetornarPorId(long id)
        {
            Produto produto = await base.RetornarPorId(id);
            produto.Categoria = await _categoriaRepositorio.RetornarPorId(produto.Id);

            return produto;
        }

        public async Task<IList<Produto>> RetornarPorCategoria(int categoriaId)
        {
            return await RetornarTodos(p => p.CategoriaId == categoriaId);
        }
    }
}