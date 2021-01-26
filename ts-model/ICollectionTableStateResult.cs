namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Combina el resultado y las consultas, para mantenerlo en redux.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICollectionTableStateResult<T> : ICollectionTableState<T>, ICollectionResult<T> { }
}
