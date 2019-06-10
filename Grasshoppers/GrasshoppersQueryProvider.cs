using System.Collections;
using System.Collections.Generic;

namespace Grasshoppers
{
    public class GrasshoppersQueryProvider : IQueriesProvider
    {
        public IEnumerator<IQuery> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}