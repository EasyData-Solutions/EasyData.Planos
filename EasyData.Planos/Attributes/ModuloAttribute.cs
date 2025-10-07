using EasyData.Planos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyData.Planos.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class ModuloAttribute : Attribute
    {
        public PlanoEnum Plano { get; }

        public string ModuloAlias { get; }

        public ModuloAttribute(PlanoEnum _plano, string _moduloAlias)
        {
            Plano = _plano;
            ModuloAlias = _moduloAlias;
        }
    }
}
