using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticoWeb.Model
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        public virtual IList<Diagnostico> Diagnosticos { get; set; } 

        public string Login { get; set; }

        public string Password { get; set; }

        public virtual IList<DiagnosticoColetivo> DiagnosticosColetivosEmQueParticipa { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Usuario other = (Usuario) obj;

            return Login == other.Login && Id == other.Id;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class UsuarioFilters
    {
        public static Usuario FiltraPorLogin(this IQueryable<Usuario> consulta, string login)
        {
            return (from usuario in consulta
                    where usuario.Login.Equals(login)
                    select usuario).FirstOrDefault();
        }
    }
}
