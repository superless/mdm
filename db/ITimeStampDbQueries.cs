using System.Threading.Tasks;
using trifenix.model;

namespace trifenix.db
{
    /// <summary>
    /// TimeStamp de una base de datos.
    /// </summary>
    public interface ITimeStampDbQueries
    {
        /// <summary>
        /// Obtiene el TimeStamp de la base de datos
        /// </summary>
        /// <typeparam name="T">Documento de la base de datos.</typeparam>
        /// <returns></returns>
        Task<long[]> GetTimestamps<T>() where T : DocumentDb;
    }
}
