using System;
using System.Runtime.Serialization;

namespace MVC_Blog.Controllers
{
    [Serializable]
    internal class HttpResponseException : Exception
    {
        private object p;

        public HttpResponseException()
        {
        }

        public HttpResponseException(string message) : base(message)
        {
        }

        public HttpResponseException(object p)
        {
            this.p = p;
        }

        public HttpResponseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}