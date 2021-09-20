using CatalogoFornecedores.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogoFornecedores.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
