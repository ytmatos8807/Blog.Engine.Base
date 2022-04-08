using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    /// <summary>
    /// Clase para manejos de errores en la repsuesta Json
    /// </summary>
    public class Error
    {
        [JsonProperty(PropertyName = "ErrorCode")]
        public String Code { get; set; }

        [JsonProperty(PropertyName = "ErrorDescription")]
        public String Message { get; set; }
    }
}
