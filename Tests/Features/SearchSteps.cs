using System;
using DataSearcher;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Features
{
    [Binding]
    public class SearchSteps
    {
        private Searcher _searcher;

        [Given(@"I am using searcher")]
        public void GivenIAmUsingSearchFeature()
        {
            _searcher = new Searcher();
        }
        
        [When(@"I enter empty string into search")]
        public void WhenIEnterString_EmptyIntoSearch()
        {
            _searcher.Search(new SearchRequest());
        }
        
        [Then(@"I get (.*) results")]
        public void ThenIGetResults(int p0)
        {
            Assert.AreEqual(p0, _searcher.NumberOfResults);
        }
    }
}
