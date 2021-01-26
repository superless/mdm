using Newtonsoft.Json;
using System.Collections.Generic;
namespace trifenix.connect.mdm.ts_model
{


    /// <summary>
    /// Datos comunes de las consultas de una tabla.
    /// que estarán presente en las consultas de una tabla.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICollectionTableState<T>{

        /// <summary>
        /// página actual.
        /// </summary>
        int Current { get; set; }


        /// <summary>
        /// índice de la entidad de la tabla.
        /// </summary>
        int Index { get; set; }


        /// <summary>
        /// Filtros de la consulta
        /// </summary>
        FilterModel Filter { get; set; }
        
        /// <summary>
        /// de las entidades encontradas relacionadas, cual es el índice de la colección 
        /// de strings que tiene el nombre que representa la entidad.
        /// dado que normalmente el resultado de la colección
        /// </summary>
        Dictionary<int, int[]> IndexPropNames { get; set; }


        /// <summary>
        /// Listado de items para el ordenamiento
        /// </summary>
        List<OrderItem> OrderItems { get; set; }
    }
}
