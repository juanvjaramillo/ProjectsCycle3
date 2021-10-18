using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace BlazorProjectIII.Client.Services
{
    public class HttpResponseWrapper<T>
    {
        public bool Error{get; set;}
        public T Response{get; set;}
        public HttpResponseMessage HttpResponseMessage{get; set;}
        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        
    }
}