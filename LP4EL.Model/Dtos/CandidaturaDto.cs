using System;
using System.Security.Cryptography.X509Certificates;


namespace LP4EL.Model.Dtos
{

	public class CandidaturaDto

	{
		public virtual int IdCandidatura { get; set; }
		public virtual int IdUsuario { get; set; }
		public virtual int IdVaga { get; set; }
	}
}

