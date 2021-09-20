using CatalogoFornecedores.Business.Models;
using System;
using System.Threading.Tasks;

namespace CatalogoFornecedores.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
