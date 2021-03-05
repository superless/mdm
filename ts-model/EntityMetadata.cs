using System.Collections.Generic;
using trifenix.connect.mdm.enums;
using trifenix.connect.ts_model.enums;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Metadata de una entidad o clase.
    /// </summary>
    public class EntityMetadata {
        /// <summary>
        /// Nombre de la entidad a mostrar
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Nombre Corto de la entidad
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// Descripción de la entidad
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Índice de la entidad
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Determina si la clase es visible
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Menú del elemento
        /// </summary>
        public GroupMenu[] Menus { get; set; }
        /// <summary>
        /// Tipo de entidad, si es de tipo entity, se podría indicar que es común,
        /// por tanto puede ser generada automáticamente.
        /// </summary>
        public EntityKind EntityKind { get; set; }


        /// <summary>
        /// cadena de texto para la ruta de la entidad,
        /// esto puede ser usado para el react router
        /// o las rutas de la api.
        /// </summary>
        public string PathName { get; set; }
        /// <summary>
        /// Autonumérico
        /// </summary>
        public bool AutoNumeric { get; set; }
        /// <summary>
        /// Nombre de la clase
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Determina si es readonly.
        /// </summary>
        public bool ReadOnly { get; set; }


        /// <summary>
        /// Nombre de la clase input.
        /// </summary>
        public string ClassInputName { get; set; }


        /// <summary>
        /// Detalles de las propiedades bajo otra vista.
        /// </summary>
        public ModelDetails ModelDetails { get; set; }

        /// <summary>
        /// Inputs de la clase.
        /// </summary>
        public InputDetails InputDetails { get; set; }

        /// <summary>
        /// Metadata de las propiedades de tipo string
        /// </summary>
        public Dictionary<int, PropertyMetadata> StringData { get; set; }
        /// <summary>
        /// Metadata de las propiedades de tipo número.
        /// </summary>
        public Dictionary<int, PropertyMetadata> NumData { get; set; }
        /// <summary>
        /// Metadata de las propiedades de tipo double.
        /// </summary>
        public Dictionary<int, PropertyMetadata> DoubleData { get; set; }
        /// <summary>
        /// Metada de las propiedades de tipo boolean
        /// </summary>
        public Dictionary<int, PropertyMetadata> BoolData { get; set; }
        /// <summary>
        /// Metadata de las propiedades de tipo geo.
        /// </summary>
        public Dictionary<int, PropertyMetadata> GeoData { get; set; }
        /// <summary>
        /// Metadata de las propiedades de tipo fecha.
        /// </summary>
        public Dictionary<int, PropertyMetadata> DateData { get; set; }
        /// <summary>
        /// propiedades de tipo enumeración.
        /// </summary>
        public Dictionary<int, PropertyMetadadataEnum> EnumData { get; set; }


        /// <summary>
        /// propiedades de tipo entidad.
        /// </summary>
        public Dictionary<int, RelatedPropertyMetadata> relData { get; set; }
    }

    public class ModelDetails {
        // <summary>
        /// Cada una de las propiedades
        /// </summary>
        public Dictionary<string, PropertyMetadata> PropsDetails { get; set; }


        /// <summary>
        /// Cada una de las propiedades de tipo related.
        /// </summary>
        public Dictionary<string, RelatedPropertyMetadata> InputRelatedDetails { get; set; }

        /// <summary>
        /// Recursividad con los campos de tipo objeto con sus propias propiedades
        /// </summary>
        public Dictionary<string, ModelDetails> RelatedInputs { get; set; }
    }

    public class InputDetails {

        /// <summary>
        /// Cada una de las propiedades
        /// </summary>
        public Dictionary<string, InputPropDetails> InputPropsDetails { get; set; }


        /// <summary>
        /// Cada una de las propiedades de tipo related.
        /// </summary>
        public Dictionary<string, InputPropRelatedDetails> InputRelatedDetails { get; set; }

        /// <summary>
        /// Recursividad con los campos de tipo objeto con sus propias propiedades
        /// </summary>
        public Dictionary<string, InputDetails> RelatedInputs { get; set; }

        /// <summary>
        /// Por cada enumeración de validación, se indican el  o los nombres de campos involucrados.
        /// las validaciones actuales solo usarían un nombre.
        /// </summary>
        public Dictionary<Validation, string[][]> ValidationsGroup { get; set; }
    }

    /// <summary>
    /// Detalles de una propiedad que no sea related.
    /// </summary>
    public class InputPropDetails : PropertyMetadata {

       
        /// <summary>
        /// Nombre del mismo campo en el modelo.
        /// </summary>
        public string ModelPropName { get; set; }
    }

    /// <summary>
    /// Detalles de una propiedad related
    /// </summary>
    public class InputPropRelatedDetails : RelatedPropertyMetadata
    {  
        /// <summary>
        /// Nombre del mismo campo en el modelo.
        /// </summary>
        public string ModelPropName { get; set; }

        /// <summary>
        /// Declara si el input es de referencia o contiene los valores de ingreso.
        /// </summary>
        public bool IsReference { get; set; }
    }


}
