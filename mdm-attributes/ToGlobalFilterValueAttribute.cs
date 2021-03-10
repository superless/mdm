using System;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina si una propiedad es usada para llegar al valor 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = true)]
    public class ToGlobalFilterValueAttribute : Attribute
    {


        /// <summary>
        /// Determina a que tipo de elemento pertenece el valor.
        /// Si una clase que es de tipo filtro no tiene GlobalFilterValue, usará el mismo valor.
        /// </summary>
        /// <param name="sourceType">con el tipo de origin se puede generar el nombre</param>
        /// <param name="targeType">Tipo de procesos (Barrack, por ej.)</param>
        public ToGlobalFilterValueAttribute(Type sourceType, Type targeType)
        {
            SourceType = sourceType;
            TargetType = targeType;
            
        }


        /// <summary>
        /// Obtiene el tipo del proceso (Barrack)
        /// </summary>
        public Type TargetType { get; }

        /// <summary>
        /// Nombre del Salto
        /// Nombre que se le dará a la ruta para llegar a la entidad de la que se requiere el valor.
        /// Cada clase que no sea parte del filtro, pero si parte del camino del filtro para llegar al 
        /// valor, usarán el mismo nombre.
        /// </summary>
        public Type SourceType { get; }

    }
}
