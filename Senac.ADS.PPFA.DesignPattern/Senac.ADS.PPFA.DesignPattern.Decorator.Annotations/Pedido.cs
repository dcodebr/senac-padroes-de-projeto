using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator.Annotations
{
    public class Pedido
    {
        [ComLeite]
        [ComAcucar]
        public Cafe cafe = new();

        public Pedido()
        {
            var campo = GetType().GetField(nameof(cafe));

            if (campo is null)
            {
                return;
            }

            if (campo.IsDefined(typeof(ComLeiteAttribute))) {
                cafe.Adicionar("leite");
            }

            if (campo.IsDefined(typeof(ComAcucarAttribute)))
            {
                cafe.Adicionar("açúcar");
            }

        }
    }
}
