using System;
using trifenix.connect.mdm.enums;
using trifenix.connect.mdm.ts_model;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// indica si una clase es agrupada para construir un menú.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class , AllowMultiple = true)]
    public class EntityGroupMenuAttribute : Attribute {



        /// <summary>
        /// Atributo para crear menús
        /// </summary>
        /// <param name="menuId">nombre del menú principal</param>
        /// <param name="device">dispositivo de renderización</param>
        /// <param name="submenu">nombre del submenú, si tiene</param>
        public EntityGroupMenuAttribute(string menuId, PhisicalDevice device, string submenu )
        {
            Grupo = new GroupMenu
            {
                Device = device,
                MenuIndex = menuId,
                SubMenuIndex  = submenu
            };
        }
        public GroupMenu Grupo { get; set; }
    }
}
