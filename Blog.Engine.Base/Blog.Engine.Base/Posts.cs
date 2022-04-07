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
        ///Lista de  Id de los comentarios
        /// </summary>
        [DataMember]
        public List<Int32> CommentId { get; set; }

        /// <summary>
        ///Cantidad de comentarios de la publicacion
        /// </summary>
        [DataMember]
        public Int32 CountComment { get; set; }

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

    }
}
