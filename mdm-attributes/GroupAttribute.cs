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
        public GroupInput Group { get; }

        /// <summary>
        /// Determina la estructura de menu
        /// </summary>
        /// <param name="orderIndex"></param>
        /// <param name="device"></param>
        public GroupAttribute(int orderIndex = 0, PhisicalDevice device = PhisicalDevice.WEB)
        {
            Group = new GroupInput
            {
                OrderIndex = orderIndex,
               
                Device = device,
                
            };
        }
    }
}
