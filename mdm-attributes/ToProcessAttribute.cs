using System;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina si una propiedad es usada para llegar a un proceso principal
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ToProcessAttribute : Attribute
    {
        /// <summary>
        /// Determina a que tipo de elemento pertenece el valor.
        /// </summary>
        /// <param name="type">Tipo de procesos (Barrack, por ej.)</param>
        public ToProcessAttribute(Type[] type)
        {
            Type = type;
        }

        /// <summary>
        /// Obtiene el tipo del proceso (Barrack)
        /// </summary>
        public Type[] Type { get; }
    }
}
