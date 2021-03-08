using System;
using trifenix.connect.mdm.enums;
using trifenix.connect.mdm.ts_model;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina una agrupación de propiedades, con el fin de definir en la metadata la estructura de un formulario.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class GroupAttribute : Attribute
    {
        /// <summary>
        /// Valores de menú
        /// </summary>
        public GroupInput Group { get; }

        /// <summary>
        /// Determina la estructura de menu
        /// </summary>
        /// <param name="menu">Nombre del menú</param>
        /// <param name="device"></param>
        /// <param name="subMenu">Nombre del submenú</param>
        public GroupAttribute(string menu, PhisicalDevice device = PhisicalDevice.WEB, string subMenu = "")
        {
            Group = new GroupInput
            {
                Menu = menu,
                SubMenu = subMenu,
                Device = device,
                
            };
        }
    }
}
