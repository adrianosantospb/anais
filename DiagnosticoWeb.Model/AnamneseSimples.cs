using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DiagnosticoWeb.Model
{
    [Table("AnamnesesSimples")]
    public class AnamneseSimples : Anamnese
    {
        public string MotivoDaVinda { get; set; }
        public string QuandoSintomaIniciou { get; set; }
        public string ComoSintomaIniciou { get; set; }
        public string ComoSintomaEvoluiu { get; set; }
        public string Intensidade { get; set; }
        public string FrequenciaRitmicidade { get; set; }
        public string IntervaloDoSintoma { get; set; }
        public string DuracaoDoSintoma { get; set; }
        public string FatoresMelhora { get; set; }
        public string FatoresPiora { get; set; }
        public string SintomasAssociados { get; set; }

        public override string VersaoTextoPlano()
        {
            // A principio apenas property do tipo string
            var result = new StringBuilder();
            foreach (var p in GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(pi => pi.PropertyType == typeof(string)))
            {
                var pValue = p.GetValue(this, null);
                if (pValue == null || (string)pValue == "")
                {
                    continue;
                }

                result.Append(p.Name);
                result.Append(":");
                result.Append(pValue);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}