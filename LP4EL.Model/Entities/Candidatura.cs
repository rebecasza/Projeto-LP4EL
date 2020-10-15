using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Model.Entities
{
    public class Candidatura
    {
		public virtual int IdCandidatura { get; set; }
		public virtual int IdUsuario { get; set; }
		public virtual int IdVaga { get; set; }

	}
}
