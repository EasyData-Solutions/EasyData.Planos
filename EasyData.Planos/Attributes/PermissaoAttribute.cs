using EasyData.Planos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public PermissaoAttribute(ModuloEnum modulo, string controleAlias, PlanoEnum plano)
        {
            var plano_modulo = modulo.GetType().GetCustomAttribute<ModuloAttribute>(inherit: true);

            if(plano != null)
                Plano = plano;
            else if(plano_modulo != null)
                Plano = plano_modulo.Plano;
            else
                throw new ArgumentException("O parâmetro plano é obrigatório quando o módulo não possui o atributo ModuloAttribute.");

            Modulo = modulo;
            ControleAlias = controleAlias;
        }

        public PermissaoAttribute(ModuloEnum modulo, string controleAlias)
        {
            var plano_modulo = modulo.GetType().GetCustomAttribute<ModuloAttribute>(inherit: true);

            if(plano_modulo != null)
                Plano = plano_modulo.Plano;
            else
                throw new ArgumentException("O parâmetro plano é obrigatório quando o módulo não possui o atributo ModuloAttribute.");

            Modulo = modulo;
            ControleAlias = controleAlias;
        }
    }
}
