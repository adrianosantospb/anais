using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagnosticoWeb.Model.Enums;

namespace DiagnosticoWeb.Model
{
    [Table("RelatosClinicos")]
    public class RelatoClinico
    {
        [Key, ForeignKey("Diagnostico")]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string NumeroDoProntuario { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DataDeInicio { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DataDeConclusao { get; set; }
        public Especialidade Especialidade { get; set; }
        public string Descricao { get; set; }

        public virtual Diagnostico Diagnostico { get; set; }

        public RelatoClinico()
        {
            DataDeInicio = DateTime.Now;
            DataDeConclusao = DateTime.Now;
        }

    }
}
