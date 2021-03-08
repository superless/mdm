using trifenix.connect.mdm.enums;
namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Agrupación de propiedades, usadas en el cliente
    /// </summary>
    public class GroupInput
    {

        /// <summary>
        /// Nombre del menú al que representa
        /// </summary>
        public string Menu { get; set; }

        /// <summary>
        /// SI es nulo, solo tendría un menú.
        /// </summary>
        public string SubMenu { get; set; }


        /// <summary>
        /// Tipo de Dispositivo
        /// </summary>
        public PhisicalDevice Device { get; set; }

    }
}
