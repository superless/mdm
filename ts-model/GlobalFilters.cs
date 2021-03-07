using System.Collections.Generic;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Global filter, Determina toda la información necesaria para hacer el filtro superior.
    /// o un filtro global.
    /// </summary>
    public class GlobalFilters {

        

        /// <summary>
        /// Colección de filtros y como llegan al valor que necesitan. por ejemplo, cost-center necesita el valor idSeason.
        /// el key sería el cost-center
        /// </summary>
        public Dictionary<string, ToValue> ToValue { get; set; }
        
        /// <summary>
        /// Determina la ruta para llegar a las distintas entidades.
        /// 
        /// Por ejemplo:
        /// 1. Cost-Center
        /// a. Obtiene el valor que corresponde al filtro, seleccionando un cost-center debe retornar el id del seasonId.
        /// b. Como sabemos que el proceso es el barrack, solo necesitamos usar el idSeason en el barrack.
        /// 2. Especie
        /// a. La especie se relaciona directo con el barrack, por tanto no sería necesario el ToValue, simplemente
        /// indicar el idSpecie para el barrack.
        /// </summary>
        public Dictionary<string, ToProcessClass[]> ToProcess { get; set; }



        /// <summary>
        /// Entidad en la que todos los filtros se unen
        /// </summary>
        public string EntityForGlobalFilters { get; set; }


        /// <summary>
        /// índice de la entidad donde los filtros se unen.
        /// cuando se unen los filtros, significa que en vez de usar los filtros
        /// se usan los del resultado de los filtros aplicados a una tabla.
        /// </summary>
        public int IndexEntityForGlobalFilters { get; set; }



    }
}
