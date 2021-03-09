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
        /// Solo se usa en propiedades de tipo entidad
        /// El objetivo es trazar la ruta de una entidad a un proceso
        /// de esa manera se podrá obtener la ruta de filtros necesarios
        /// para que un elemento filtre un proceso.
        /// Para trazar se usa este atributo, en la clase o propiedad
        /// si fuera en la clase significaría, que el camino estaría 
        /// en una de las clases que tienen el identificador del origen
        /// por tanto buscaría en todos los elementos que tengan alguna propiedad
        /// que apunta al origen, una vez identificada se revisará si es el objetivo o debe
        /// saltar a otro elemento para llegar al objetivo
        /// Si el atributo estuviera en la propiedad sería más fácil
        /// porque con los datos de la propiedad se podrá saber cual es el próximo paso.
        /// </summary>
        /// <param name="name">Nombre de la ruta, se usa como identificador de la ruta</param>
        /// <param name="type">Tipo de procesos (Barrack, por ej.)</param>
        /// <param name="jump">Determina si es el inicio de la ruta (true) o es un camino para llegar a ella (false)</param>
        /// <param name="isGlobalFilter">Determina si el proceso es global filter</param>
        public ToProcessAttribute(string name, Type[] type, bool jump, bool isGlobalFilter)
        {
            Name = name;
            Type = type;
            Jump = jump;
            IsGlobalFilter = isGlobalFilter;
        }

        /// <summary>
        /// Obtiene el tipo del proceso (Barrack)
        /// </summary>
        public Type[] Type { get; }

        /// <summary>
        /// Nombre del Salto
        /// Nombre que se le dará a la ruta para llegar a la entidad de la que se requiere el valor.
        /// Cada clase que no sea parte del filtro, pero si parte del camino del filtro para llegar al 
        /// valor, usarán el mismo nombre.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Salto
        /// si es verdadero, significa que la propiedad o clase que representa una entidad, 
        /// no es un filtro, sino que solo registra el salto del filtro para llegar al valor.
        /// </summary>
        public bool Jump { get; }
        public bool IsGlobalFilter { get; }
    }
}
