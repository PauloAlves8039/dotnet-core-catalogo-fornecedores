using CatalogoFornecedores.Business.Models;
using System;
using System.Threading.Tasks;

namespace CatalogoFornecedores.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
