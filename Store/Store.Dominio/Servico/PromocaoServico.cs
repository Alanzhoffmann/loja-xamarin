using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class PromocaoServico : ServicoBase<Promocao>
    {
        private readonly IPromocaoRepositorio _repositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public PromocaoServico(IPromocaoRepositorio repositorio, ICategoriaRepositorio categoriaRepositorio) : base(repositorio)
        {
            _repositorio = repositorio;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public override async Task<IList<Promocao>> RetornarTodos(Predicate<Promocao> filter = null)
        {
            IList<Promocao> promocoes = await base.RetornarTodos(filter);
            IList<Categoria> categorias = await _categoriaRepositorio.RetornarTodos();

            foreach (Promocao promocao in promocoes)
            {
                Categoria categoria = categorias.FirstOrDefault(c => c.Id == promocao.CategoriaId);
                if (categoria != null)
                {
                    promocao.Categoria = categoria;
                }
            }

            return promocoes;
        }

        public async Task<Promocao> RetornarPorCategoria(int categoriaId)
        {
            IList<Promocao> promocoes = await base.RetornarTodos(p => p.CategoriaId == categoriaId);
            return promocoes?.FirstOrDefault();
        }
    }
}