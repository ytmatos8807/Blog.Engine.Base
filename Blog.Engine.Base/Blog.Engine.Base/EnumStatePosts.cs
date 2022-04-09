using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Engine.Base
{
    /// <summary>
    /// Estados por los que pasan las publicaciones
    /// </summary>
    public enum EnumStatePosts
    {
        Published,
        Submitted,
        PendingApproval,
        Pending
    }
}
