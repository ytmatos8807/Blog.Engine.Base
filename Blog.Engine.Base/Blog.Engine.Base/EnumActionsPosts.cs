using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    /// <summary>
    /// Acciones a realizar sobre las publicaciones(Obtener, Crear, editar, enviar, aprobar o rechazar)
    /// </summary>
    public enum EnumActionsPosts
    {
        GetPosts,
        CreatePosts,
        EditPosts,
        SubmitPosts,
        ApprovePosts,
        RejectPosts
    }
}
