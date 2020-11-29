using System;
namespace trifenix.connect.mdm.validation_attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    /// <summary>
    /// Atributo que declara una referencia
    /// es decir, que una propiedad es una referencia de otro elemento
    /// asignando el identificador de este
    /// Este atributo es utilizado para determinar si existe el elemento en la base de datos.
    /// </summary>
    public class ReferenceAttribute : Attribute
    {
        /// <summary>
        /// Tipo de la entidad de referencia
        /// </summary>
        public Type entityOfReference;
        /// <summary>
        /// Constructor con el tipo de entidad a la que se refiere el id
        /// </summary>
        /// <param name="_entityOfReference">Entidad de la Referencia</param>
        public ReferenceAttribute(Type _entityOfReference)
        {
            entityOfReference = _entityOfReference;
        }
    }
}