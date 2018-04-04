using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Abstractions;
using NSubstitute;
using Controle.Services.Api.Controllers;


namespace Controle.Test.Controle.Domain.Test.ServicesTest
{
    public class OrdemServicoServiceTest : Controller
    {
        private readonly ITestOutputHelper output;

        [Fact]
        public void VerificarSeIntegracaoEstaFuncionando()
        {
            var ordemServicoIntegrar = new OrdemServicoController();
            output.WriteLine(ordemServicoIntegrar.Integrar().ToString());
            Assert.True(ordemServicoIntegrar.Integrar() == Json("Ordem de serviço integrada com sucesso."));
        }
    }
}
