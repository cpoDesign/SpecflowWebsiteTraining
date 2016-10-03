Feature: Search
	In order to avoid silly mistakes
	I want basic search ablitity to return results

@Search
Scenario: As user of the search I want to be able to enter Search location and get number of results
	Given I am using searcher
	When I enter empty string into search
	Then I get 0 results

