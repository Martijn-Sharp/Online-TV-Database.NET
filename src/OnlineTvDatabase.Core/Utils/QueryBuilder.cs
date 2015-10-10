using System.Text;

namespace OnlineTvDatabase.Core.Utils
{
    public class QueryBuilder
    {
        private readonly StringBuilder _queryBuilder = new StringBuilder();

        public void Append(string key, string value)
        {
            bool firstEntry = _queryBuilder.Length == 0;
            if (!firstEntry)
            {
                _queryBuilder.Append("&");
            }

            _queryBuilder.Append($"{key}={UrlUtils.UrlEncode(value)}");
        }

        public override string ToString()
        {
            return _queryBuilder.ToString();
        }
    }
}
