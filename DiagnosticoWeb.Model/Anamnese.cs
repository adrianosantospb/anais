using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiagnosticoWeb.Model
{
    [Table("Anamneses")]
    public abstract class Anamnese
    {
        [Key, ForeignKey("Diagnostico")]
        public int Id { get; set; }

        public virtual Diagnostico Diagnostico { get; set; }

        // Usado para indexação no Solr. Todo tipo de anamnese deve implementar
        public abstract string VersaoTextoPlano();
    }
}
