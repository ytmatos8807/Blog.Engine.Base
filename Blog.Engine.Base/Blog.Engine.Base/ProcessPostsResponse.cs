using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    [DataContract]
    public class ProcessPostsResponse
    {
        public ProcessPostsResponse()
        {
            this.Details = new List<Posts>();
        }

        /// <summary>
        /// estado de la validacion
        /// </summary>
        [DataMember]
        public ResultState State { get; set; }

        /// <summary>
        /// Mensaje del proceso Error o Exito
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Detalle de publicaciones
        /// </summary>
        [DataMember]
        public List<Posts> Details { get; set; }
    }
}
