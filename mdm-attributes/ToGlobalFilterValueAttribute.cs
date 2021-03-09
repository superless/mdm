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
        /// <param name="name">Nombre del filtro</param>
        /// <param name="type">Tipo del elemento a obtener</param>
        /// <param name="jump">Si es jump, solo es para obtener el camino</param>
        public ToGlobalFilterValueAttribute(string name, Type type, bool jump)
        {
            Name = name;
            Type = type;
            Jump = jump;
        }


        /// <summary>
        /// Nombre del Salto
        /// Nombre que se le dará a la ruta para llegar a la entidad de la que se requiere el valor.
        /// Cada clase que no sea parte del filtro, pero si parte del camino del filtro para llegar al 
        /// valor, usarán el mismo nombre.
        /// </summary>
        public string Name { get; }


        /// <summary>
        /// Tipo al que tiene que llegar, para trazar la ruta, a través de este mismo atributo
        /// </summary>
        public Type Type { get; }


        /// <summary>
        /// Salto
        /// si es verdadero, significa que la propiedad o clase que representa una entidad, 
        /// no es un filtro, sino que solo registra el salto del filtro para llegar al valor.
        /// </summary>
        public bool Jump { get; }
    }
}
