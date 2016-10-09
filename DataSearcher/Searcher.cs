using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearcher
{
    public class Searcher
    {
        private SearchResponse _response;

        public void Search(SearchRequest request)
        {
            _response = new SearchResponse();

            NumberOfResults = _response.NumberOfResults;
        }

        public int NumberOfResults { get; set; }
    }

    public class SearchRequest
    {
        public string SearchTerm { get; set; }
    }

    public class SearchResponse
    {
        public SearchResponse()
        {
            this.Results = new List<object>();
        }

        public int NumberOfResults { get { return Results.Count(); } }
        public IEnumerable<Object> Results { get; set; }
    }
}
