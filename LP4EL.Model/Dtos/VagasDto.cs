using System;
using System.Security.Cryptography.X509Certificates;


namespace LP4EL.Model.Dtos
{ 

public class VagasDto

{
	public virtual int IdVaga { get; set; }
	public virtual string Titulo { get; set; }
	public virtual string Descricao { get; set; }
	public virtual string Localizacao { get; set; }
	}
}

