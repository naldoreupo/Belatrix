using System.Collections.Generic;

namespace Belatrix.Logger.Transversal
{
    public class Response<T>
    {
        public T Data { get; set; }
        public IEnumerable<T> Lista { get; set; }

        public bool Success { get; set; }
        public string Message { get; set; }

        public Response()
        {
            // Prevent outside instantiation
        }

        private static readonly Response<T> _reponse = new Response<T>();

        public static Response<T> GetSingleton()
        {
            return _reponse;
        }

    }

}
