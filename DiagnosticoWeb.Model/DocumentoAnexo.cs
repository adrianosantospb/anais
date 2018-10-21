using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoWeb.Model
{
    [Table("Documentos")]
    public class DocumentoAnexo : LinkDeApoioAoDiagnostico
    {
        public string NomeDoArquivo { get; set; }
        public string ContentType { get; set; }
        public string Descricao { get; set; }
    }
}
