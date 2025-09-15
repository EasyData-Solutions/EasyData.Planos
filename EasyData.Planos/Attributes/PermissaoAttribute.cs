using EasyData.Planos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyData.Planos.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class PermissaoAttribute : Attribute
    {
        public PlanoEnum Plano { get; }

        public ModuloEnum Modulo { get; }

        public string ControleAlias { get; }

        public PermissaoAttribute(PlanoEnum plano, ModuloEnum modulo, string controleAlias)
        {
            Plano = plano;
            Modulo = modulo;
            ControleAlias = controleAlias;
        }
    }
}
