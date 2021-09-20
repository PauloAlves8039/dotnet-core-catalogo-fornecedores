using CatalogoFornecedores.Business.Models;
using System;
using System.Threading.Tasks;

namespace CatalogoFornecedores.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
