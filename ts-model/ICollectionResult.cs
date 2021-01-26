using trifenix.connect.mdm.entity_model;
namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Clase de Typescript creada en C#, solo tiene funcionalidad en Typescript
    /// es parte del modelo trifenix/mdm generado automáticamente desde C#.
    /// Resultado de una consulta de entidades.
    /// Los valores incluidos + la consulta, permiten refrescar.
    /// </summary>
    public interface ICollectionResult<T>
    {
        /// <summary>
        /// Total de registros
        /// </summary>
        long Total { get; set; }
        /// <summary>
        /// Entidades que retorna
        /// </summary>
        IEntitySearch<T>[] Entities { get; set; }


        /// <summary>
        /// Agrupaciones de busqueda.
        /// </summary>
        Facet[] Facets { get; set; }
    }
}
