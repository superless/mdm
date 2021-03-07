namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Determina la ruta de filtros para el proceso que da origin a todos los filtros.
    /// En este caso, al ser barrack el corazón, usará esta clase para determinar la ruta.
    /// </summary>
    public class ToProcessClass {

        /// <summary>
        /// Determina la ruta para llegar a la entidad de proceso principal (ej. barrack).
        /// </summary>
        public PathToFiltersValue[] PathToProcess { get; set; }

        /// <summary>
        /// Clase a llegar, ej : Barrack
        /// </summary>
        public string ProcessNameClass { get; set; }


        /// <summary>
        /// índice de la clase, para usarlo en la consulta.
        /// </summary>
        public int IndexProcessClass { get; set; }
    }
}
