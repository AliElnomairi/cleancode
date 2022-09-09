﻿
namespace cleancode.shared
{
    public static class Response
    {
        public static Response<T> Error<T>(string message, T data = default) =>
            new(data, message, true);

        public static Response<T> Success<T>(T data, string message) =>
            new(data, message, false);
    }
        public class Response<T>
        {
            public Response() { }
            public Response(T data, string message, bool error)
            {
                Data = data;
                Message = message;
                Error = error;
            }

            public T Data { get; set; }
            public string Message { get; set; }
            public bool Error { get; set; }
        }
}
