namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Metadata de propiedades de tipo relación.
    /// </summary>
    public class RelatedPropertyMetadata : PropertyMetadata {

        /// <summary>
        /// índice real de una entidad,
        /// existe el caso en el que una clase puede tener dos propiedades que apuntan a la misma entidad. 
        /// Por ejemplo el caso de barrack, tiene variedad en dos propiedades, pollinator y variety.
        /// Esto afecto el modelo entitySearch, dado que una colección de relaciones de entitySearch
        /// es un array con el índice de la propiedad y el valor. este índice identifica el tipo de entidad,
        /// pero cuando existen dos propiedades que apuntan a la misma entidad, no es posible identificarlos,
        /// salvo por la metadata.
        /// En este caso RealIndex le dice que asignaremos a pollinator el 23, pero realmente es el 21.
        /// Esto permite que el array de propiedades de relaciones de una relación, considere ambos, 
        /// pero a la hora de seleccionar el valor que corresponde a pollinator (23) debe 
        /// usar el tipo de entidad 21 (variedad)
        /// Este valor índica a través de la metadata de esta excepción.
        /// Este valor es nullable, debido a que es un comportamiento excepcional
        /// </summary>
        public int? RealIndex { get; set; }

        /// <summary>
        /// Indica el nombre de la clase a la que apunta el related.
        /// </summary>
        public string ClassNameTarget { get; set; }

        /// <summary>
        /// Determina si es por referencia.
        /// </summary>
        public bool IsReference { get; set; }

    }
}
