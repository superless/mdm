namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Ruta para llegar al valor, por ejemplo, desde cost-center a idSeason.
    /// </summary>
    public class ToValue {

        /// <summary>
        /// Ruta para llegar al valor de un filtro.
        /// </summary>
        public PathToFiltersValue[] FiltersToValue { get; set; }

        /// <summary>
        /// Clase a llegar, ej : Barrack
        /// </summary>
        public string ProcessNameClass { get; set; }


        /// <summary>
        /// índice de la clase, para usarlo en la consulta.
        /// </summary>
        public int IndexProcessClass { get; set; }

        /// <summary>
        /// Nombre del filtro o ruta del filtro.
        /// </summary>
        public string Name { get; set; }

    }
}
