using System;
using TechTalk.SpecFlow;

namespace DevBoost.Test.Integration.resource.steps
{
    [Binding]
    public class ValidarLoginSteps
    {
        [Given(@"um usuario ""(.*)"" com o perfil de administrado")]
        public void DadoUmUsuarioComOPerfilDeAdministrado(string p0)
        {            
            ScenarioContext.Current.Pending();
        }
        
        [When(@"preenche o campo senha com a ""(.*)""")]
        public void QuandoPreencheOCampoSenhaComA(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"aciona o envio")]
        public void QuandoAcionaOEnvio()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o usuario recebe o statusCode ""(.*)""")]
        public void EntaoOUsuarioRecebeOStatusCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
