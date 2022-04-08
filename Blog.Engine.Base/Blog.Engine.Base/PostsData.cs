using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    /// <summary>
    /// Clase para retorno de datos de listado de publicaciones publicadas
    /// </summary>
    public class PostsData
    {
        public PostsData()
        {
            Data = new List<Posts>();
        }
        public List<Posts> Data { get; set; }
    }
}
