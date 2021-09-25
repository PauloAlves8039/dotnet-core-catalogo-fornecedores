using CatalogoFornecedores.Business.Interfaces;
using CatalogoFornecedores.Business.Notificaoes;
using CatalogoFornecedores.Business.Services;
using CatalogoFornecedores.Data.Context;
using CatalogoFornecedores.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CatalogoFornecedores.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<FornecedorDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
