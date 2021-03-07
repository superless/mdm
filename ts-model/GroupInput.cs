using trifenix.connect.mdm.enums;
namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Agrupación de propiedades, usadas en el cliente
    /// </summary>
    public class GroupInput
    {
        /// <summary>
        /// índice usado para ordenar los grupos de propiedades
        /// </summary>
        public int OrderIndex { get; set; }


        /// <summary>
        /// Tipo de Dispositivo
        /// </summary>
        public PhisicalDevice Device { get; set; }
        /// <summary>
        /// Proporción de columna, usada para determinar su posición.
        /// se usa en base 12, es decir 12 es el ancho total.
        /// </summary>
        public int ColumnProportion { get; set; }
    }
}
