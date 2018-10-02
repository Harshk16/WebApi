using System.Collections.Generic;

namespace WebApi.Common
{
    public class ErrorList : List<KeyValuePair<string, string>>
    {
        public ErrorList()
        {
        }

        public ErrorList(IEnumerable<KeyValuePair<string, string>> collection)
            : base(collection)
        {
        }

        public ErrorList(int capacity)
            : base(capacity)
        {
        }
    }
}