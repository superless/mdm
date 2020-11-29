using trifenix.connect.mdm.enums;

namespace trifenix.connect.mdm.containers
{
    /// <summary>
    /// Envía de regreso las operaciones de tipo Post.
    /// </summary>
    /// <typeparam name="T">Tipo de Resultado</typeparam>
    public class ExtPostContainer<T>
    {
        /// <summary>
        /// Mensaje con el resultado
        /// </summary>
        /// <value></value>
        public ExtMessageResult MessageResult { get; set; }

        /// <summary>
        /// Mensaje de error si existiese
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Resultado del envío.
        /// </summary>
        /// <value>Tupo de Resultado</value>
        public T Result { get; set; }

        /// <summary>
        /// Identificador del elemento relacionado en el post
        /// </summary>
        public string IdRelated { get; set; }
    }
}
