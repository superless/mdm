using System;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina si una propiedad es usada para llegar a un proceso principal
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = true)]
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
        /// <param name="sourceType">con el tipo de origin se puede generar el nombre</param>
        /// <param name="targeType">Tipo de procesos (Barrack, por ej.)</param>
        /// <param name="isGlobalFilter">Determina si el proceso es global filter</param>
        public ToProcessAttribute(Type sourceType, Type targeType, bool isGlobalFilter)
        {
            SourceType = sourceType;
            TargetType = targeType;
            
            IsGlobalFilter = isGlobalFilter;
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

        
        /// <summary>
        /// Determina si es parte de un filtro global.
        /// </summary>
        public bool IsGlobalFilter { get; }
    }
}
