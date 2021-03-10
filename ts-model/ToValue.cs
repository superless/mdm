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
        /// nombre de la clase original o ruta del filtro.
        /// </summary>
        public string origin { get; set; }


        /// <summary>
        /// Índice del elemento original
        /// </summary>
        public int IndexOrigin { get; set; }

    }
}
