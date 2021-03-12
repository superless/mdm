namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Determina la ruta de filtros para el proceso que da origin a todos los filtros.
    /// En este caso, al ser barrack el corazón, usará esta clase para determinar la ruta.
    /// </summary>
    public class ToProcessClass : PathCollection  {


        
        
        /// <summary>
        /// Nombre de la ruta de filtros
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Índice en la ruta de filtros.
        /// </summary>
        public int Index { get; set; }



        

        /// <summary>
        /// Clase a llegar, ej : Barrack
        /// </summary>
        public string TargetName { get; set; }


        /// <summary>
        /// índice de la clase, para usarlo en la consulta.
        /// </summary>
        public int TargetIndex { get; set; }


        /// <summary>
        /// Existe un caso en partícular en Barrack, donde existen dos propiedades que apuntan a la misma entidad
        /// Pollinator y Variety apuntan a variety.
        /// Para solucionar esto se usa Index y RealIndex
        /// En el caso de ToProcess se podría dar el siguiente ejemplo:
        /// Tengo variedad y quiero ver todas las órdenes que hayan usado un barrack que uso esta como polinizador
        /// y también de ver las órdenes que hayan usado un barrack que uso esta como variedad.
        /// Para poder llegar a esa ruta, el atributo toProcess debe saltar desde variedad,
        /// donde tendrá el atributo en su clase
        /// hasta cada una de las propiedades.
        /// para el resto no sería necesario llegar a la propiedad
        /// el nombre de la clave que aloja esta clase, deberá ser formado por el {SourceName}-{TargetName} y la 
        /// propiedad que identifica la variedad (idPollinator u idVariety).
        /// El nombre de la propiedad es obtenido del último salto de PathToProcess
        /// y de esta propiedad se obtiene el index y el real index, donde el real index es el índice de variety, que 
        /// será donde buscará realmente los varieties y el index, que en este caso es Pollinator, solo servirá 
        /// para diferenciar las propiedades, para el caso, poder filtrar variety como pollinator o como variety propiamente tal.
        /// </summary>
        public int TargetRealIndex { get; set; }

        /// <summary>
        /// nombre de la clase original o ruta del filtro.
        /// </summary>
        public string SourceName { get; set; }


        /// <summary>
        /// Índice del elemento original
        /// </summary>
        public int SourceIndex { get; set; }

        



    }
}
