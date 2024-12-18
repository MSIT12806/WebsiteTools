using System.Collections.Generic;
using System.Linq;

namespace WebsiteTools
{
    public static class EnumerableExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> src)
        {
            return src == null || src.Count() == 0;
        }
    }
}
