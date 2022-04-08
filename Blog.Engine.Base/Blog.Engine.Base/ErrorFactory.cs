using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    public class ErrorFactory
    {
        public static Error Build(Exception e)
        {
            return new Error
            {
                Code = "FTL",
                Message = e.Message
            };
        }
    }
}
