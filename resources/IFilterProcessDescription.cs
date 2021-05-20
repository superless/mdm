using trifenix.connect.mdm.ts_model;
namespace trifenix.connect.mdm.resources
{
    /// <summary>
    /// Interface para obtener la descripción de filtros.
    /// </summary>
    public interface IFilterProcessDescription {

        /// <summary>
        /// Obtiene el detalla y descripción de un filtro
        /// </summary>
        /// <param name="index">índice para el filtro</param>
        /// <returns>Descripción</returns>
        DocFilter GetFilterProcessDescription(int index);
    }
}
