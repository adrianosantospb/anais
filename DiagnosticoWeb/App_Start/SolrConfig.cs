using DiagnosticoWeb.Services;

namespace DiagnosticoWeb
{
    public class SolrConfig
    {
        public static void SetupMappingAndStartup()
        {
            ServicoIndexacaoSolr.Inicializa();
        }
    }
}