using System;
using System.Runtime.Serialization;

namespace TeamCitySharper
{
    [Serializable]
    internal class TeamCityApiException : Exception
    {
        public TeamCityApiException()
        {
        }

        public TeamCityApiException(string message) : base(message)
        {
        }

        public TeamCityApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamCityApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}