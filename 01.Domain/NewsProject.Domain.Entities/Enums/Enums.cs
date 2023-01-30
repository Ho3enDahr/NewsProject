using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Enums
{
   public enum EnumFileType
    {
        Image=1,
        Video=2,
        Audio=3,
        Document = 4
    }
    public enum EnumContentType
    {
        News = 1,
        Article=2,
        ImageGallery=3,
        Video=4
    }
    public enum EnumCommentStatus
    {
        New = 1,
        Accept=2,
        Reject=3
    }
}
