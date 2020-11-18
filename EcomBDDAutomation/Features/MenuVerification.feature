Feature: Menu Verification

As a user 
I should be navigating through Menu Options
	
Scenario: Navigating through menu

Given I'm on HomePage "http://www.next.co.uk"
When I click on Menu Option 
Then I should see list of appropriate subMenu Options

