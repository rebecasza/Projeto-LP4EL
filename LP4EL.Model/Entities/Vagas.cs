using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Model.Entities
{
    public class Vagas
    {

        public virtual int IdVaga { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Localizacao { get; set; }

    }


}
