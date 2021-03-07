using System;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina si una propiedad es usada para llegar al valor 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ToGlobalFilterValueAttribute : Attribute
    {
        /// <summary>
        /// Determina a que tipo de elemento pertenece el valor.
        /// Si una clase que es de tipo filtro no tiene GlobalFilterValue, usará el mismo valor.
        /// </summary>
        /// <param name="type"></param>
        public ToGlobalFilterValueAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// Filtro principal
        /// </summary>
        public Type Type { get; }
    }
}
