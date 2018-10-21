using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoWeb.Model
{
    [Table("Acompanhamentos")]
    public class Acompanhamento
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime Data { get; set; }
        public string Procedimento { get; set; }
        public string Responsavel { get; set; }
        public string EfeitosColaterais { get; set; }
        public string Observacoes { get; set; }

        public virtual ProcedimentosRealizados ProcedimentoRealizado { get; set; }
    }
}
