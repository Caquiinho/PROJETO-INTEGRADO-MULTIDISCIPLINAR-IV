using Applications.Configuration;
using Applications.Interfaces;
using Applications.Services;
using Infrastructure.Configuration;
using Infrastructure.Factory;
using Infrastructure.Interface;
using Infrastructure.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Presentation.ModuloInicial;
using Presentation.ModuloPerfil;
using Presentation.ModuloProduto;
using Presentation.ModuloUsuario;
using Repository.Repository;

namespace Presentation.Start
{
    public static class ServiceProviderBuilder
    {
        public static ServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();

            //Forms
            serviceCollection.AddTransient<frmIncluirPerfil>();
            serviceCollection.AddTransient<ModuloCliente.frmGerenciarCliente>();
            serviceCollection.AddTransient<frmIncluirUsuario>();
            serviceCollection.AddTransient<frmMenu>();
            serviceCollection.AddTransient<frmLogin>();
            serviceCollection.AddTransient<frmAlterarProduto>();

            //Factory
            serviceCollection.AddScoped<SqlFactory>();

            //Repository
            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();
            serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
            serviceCollection.AddTransient<IPerfilRepository, PerfilRepository>();
            serviceCollection.AddTransient<IProdutoRepository, ProdutoRepository>();

            //Service
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IPerfilService, PerfilService>();
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();

            //ConfigurationService
            serviceCollection.AddScoped<ServiceConfiguration>(provider => new ServiceConfiguration
            {
                clienteService = provider.GetRequiredService<IClienteService>(),
                usuarioService = provider.GetRequiredService<IUsuarioService>(),
                perfilService = provider.GetRequiredService<IPerfilService>(),
                produtoService = provider.GetRequiredService<IProdutoService>()
            });

            //ConfigurationRepository
            serviceCollection.AddScoped<RepositoryConfiguration>(provider => new RepositoryConfiguration
            {
                clienteRepository = provider.GetRequiredService<IClienteRepository>(),
                usuarioRepository = provider.GetRequiredService<IUsuarioRepository>(),
                perfilRepository = provider.GetRequiredService<IPerfilRepository>(),
                produtoRepository = provider.GetRequiredService<IProdutoRepository>()   
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}