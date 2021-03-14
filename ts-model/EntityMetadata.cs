using System.Collections.Generic;
using trifenix.connect.mdm.enums;
using trifenix.connect.model;
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
        /// Nombre de la clase input si existe
        /// </summary>
        public string ClassNameInput { get; set; }

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

        /// <summary>
        /// Documentación de la clase.
        /// </summary>
        public EntitySearchDisplayInfo Info { get; set; }


        /// <summary>
        /// Estructura para eliminar elementos
        /// </summary>
        public DeleteItem[] DeleteItems { get; set; }


        /// <summary>
        /// Determina si el elemento es el valor de un filtro global
        /// 
        /// </summary>
        public bool IsGlobalFilterValue { get; set; }


        /// <summary>
        /// Ruta a cualquier entidad, generalmente se indicarán aquellas que se quiera que este 
        /// sea filtro.
        /// </summary>
        public ToProcessClass[] ToProcessClass { get; set; }



        /// <summary>
        /// Colección con filtros exitentes en la entidad y su documentación.
        /// </summary>
        public FilterProcess[] FiltersProcess { get; set; }

        /// <summary>
        /// Determina los filtros disponibles, de acuerdo al atributo ToGlobalFilterProcess
        /// </summary>
        public RelatedItem[] FiltersAvailable { get; set; }

    }
}
