using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Requesters.Extensions
{
    public static class DictionaryExtensions
    {
        public static string ToQueryParameters(this Dictionary<string, string> queryDictionary)
        {
            if (queryDictionary == null || queryDictionary.Count == 0)
                return string.Empty;
            var sb = new StringBuilder("?");
            sb.AppendJoin('&', queryDictionary.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            return sb.ToString();
        }
    }
}