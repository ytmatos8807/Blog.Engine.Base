using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    public class Result
    {
        public ResultState State { get; set; }

        public Int64 Code { get; set; }

        public string Message { get; set; }
    }
}
