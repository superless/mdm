namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// ruta para llegar al próximo valor para el filtro
    /// por ejemplo, este puede ser centro de costos,
    /// para llegar al filtro debe llegar a las tablas de procesos principales.
    /// Por cada filtro se debe llegar a una colección de órdenes, pre-ordenes, ejecuciones, etc.
    /// </summary>
    public class PathToFiltersValue {

        /// <summary>
        /// el nombre de la clase para el valor
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// el nombre de la clase que está solicitando el valor.
        /// </summary>
        public string OriginalClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IdProperty { get; set; }

        /// <summary>
        /// índice de la clase a consultar, esto permite poder hacer consultas de tipo Search.
        /// por ejemplo, filter = index eq {RealIndex} and rel/index == {OriginalIndex} and rel/id = {cost-center-id}
        /// </summary>
        public int RealIndex { get; set; }

        /// <summary>
        /// índice del elemento a conseguir el valor.
        /// </summary>
        public int OriginalIndex { get; set; }


    }
}
