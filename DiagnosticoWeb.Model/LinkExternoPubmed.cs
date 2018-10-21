using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoWeb.Model
{
    [Table("LinksExternosPubmed")]
    public class LinkExternoPubmed : LinkDeApoioAoDiagnostico
    {
        public string PubmedId { get; set; }
        public string Autor { get; set; }
        public string LinkFullText { get; set; }
    }
}
