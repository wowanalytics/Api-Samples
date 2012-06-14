using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wow.ApiLibrary.Models
{
    public class Result<T>
    {
        public T Data { get; set; }

        public Error Error { get; set; } 
    }
}
