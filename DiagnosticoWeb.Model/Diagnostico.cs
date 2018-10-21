using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DiagnosticoWeb.Model.Enums;

namespace DiagnosticoWeb.Model
{
    [Table("Diagnosticos")]
    public class Diagnostico
    {
        public int Id { get; set; }
        public virtual Anamnese Anamnese { get; set; }
        public virtual RelatoClinico RelatoClinico { get; set; }

        public virtual IList<LinkDeApoioAoDiagnostico> Links { get; set; } 

        public virtual DiagnosticoColetivo DiagnosticoColetivo { get; set; }

        public virtual ProcedimentosRealizados ProcedimentosRealizados { get; set; }

        public virtual Usuario EspecialistaResponsaavel { get; set; }

        public void CriaAnamnese()
        {
            if (Anamnese == null)
            {
                switch (RelatoClinico.Especialidade)
                {
                    case Especialidade.Cardiologia:
                        Anamnese = new AnamneseCardiologia();
                        break;
                    default:
                        Anamnese = new AnamneseSimples();
                        break;
                }
            }
        }
    }

    public static class DiagnosticoFilters
    {
        public static List<Diagnostico> FiltraPorUsuario(this IQueryable<Diagnostico> consulta, string login)
        {
            return (from diagnostico in consulta
                    where diagnostico.EspecialistaResponsaavel.Login.Equals(login)
                    select diagnostico).ToList();
        }
    }


}