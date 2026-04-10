using System;

namespace AgOpenGPS.Core.AgShare
{
    public class AgShareResult
    {
        private static readonly AgShareResult _success = new AgShareResult();

        private AgShareResult()
        {
        }

        private AgShareResult(AgShareError error)
        {
            Error = error ?? throw new ArgumentNullException(nameof(error));
        }

        public bool IsSuccessful => Error == null;
        public AgShareError Error { get; }

        public static AgShareResult Success()
        {
            return _success;
        }

        public static AgShareResult Failure(AgShareError error)
        {
            return new AgShareResult(error);
        }
    }

    public class AgShareResult<T>
        where T : class
    {
        private AgShareResult(T data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
        }

        private AgShareResult(AgShareError error)
        {
            Error = error ?? throw new ArgumentNullException(nameof(error));
        }

        public bool IsSuccessful => Error == null;
        public T Data { get; }
        public AgShareError Error { get; }

        public static AgShareResult<T> Success(T data)
        {
            return new AgShareResult<T>(data);
        }

        public static AgShareResult<T> Failure(AgShareError error)
        {
            return new AgShareResult<T>(error);
        }
    }
}
