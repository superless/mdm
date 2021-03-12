namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Clase Padre con las rutas para llegar a una entidad.
    /// </summary>
    public class PathCollection {
        /// <summary>
        /// Determina la ruta para llegar a la entidad de proceso principal (ej. barrack).
        /// </summary>
        public PathToFiltersValue[] PathToProcess { get; set; }
    }
}
