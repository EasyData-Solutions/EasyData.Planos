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

        public PermissaoAttribute(ModuloEnum _modulo, string _controleAlias, PlanoEnum _plano)
        {
            var plano_modulo = _modulo.GetType().GetCustomAttribute<ModuloAttribute>(inherit: true);

            if(_plano != null)
                Plano = _plano;
            else if(plano_modulo != null)
                Plano = plano_modulo.Plano;
            else
                Plano = PlanoEnum.Complementos;

            Modulo = _modulo;
            ControleAlias = _controleAlias;
        }

        public PermissaoAttribute(ModuloEnum _modulo, string _controleAlias)
        {
            var plano_modulo = _modulo.GetType().GetCustomAttribute<ModuloAttribute>(inherit: true);

            if (plano_modulo != null)
                Plano = plano_modulo.Plano;
            else
                Plano = PlanoEnum.Complementos;

            Modulo = _modulo;
            ControleAlias = _controleAlias;
        }
    }
}
