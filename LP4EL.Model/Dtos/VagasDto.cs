using System;
using System.Security.Cryptography.X509Certificates;


namespace LP4EL.Model.Dtos
{ 

public class VagasDto

{
	public virtual int IdVaga { get; set; }
	public virtual string Nome { get; set; }
	public virtual string descricao { get; set; }
	public virtual string NomeCandidato { get; set; }

}
}

