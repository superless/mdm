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
        

}
