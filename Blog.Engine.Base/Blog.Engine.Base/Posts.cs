using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    [DataContract]
    public class Posts
    {
        /// <summary>
        /// Id de la publicacion
        /// </summary>
        [DataMember]
        public Int32 PostsId { get; set; }

        /// <summary>
        /// Estado de la publicacion
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        ///Cantidad de comentarios de la publicacion
        /// </summary>
        [DataMember]
        public Int32 AmountComment { get; set; }

        /// <summary>
        ///Titulo de la publicacion
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        ///Contenido de la publicacion
        /// </summary>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        ///Autor de la publicacion
        /// </summary>
        [DataMember]
        public string Author { get; set; }

        /// <summary>
        ///Fecha de la publicacion
        /// </summary>
        [DataMember]
        public DateTime DatePosts { get; set; }

        /// <summary>
        /// Identifica si una publicacion esta bloqueada o no (S/N)
        /// </summary>
        public string Blocked { get; set; }

    }
}
