using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helps
{
    public class CommentQueryObject
    {
        public string? title { get; set; } = string.Empty;

        public bool IsDescending { get; set; } = false;

    }
}