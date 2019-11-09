Feature: Registration By Simple Specflow feature
	This functionality covers tests for registration with construction online website.

Scenario: Choose your plan 
	Given Construction online home page is launched
	And  Register Now link is being displayed
	When Click on Register now link
	Then Verify that it takes to the sign up for contruction page
	When Plan selection page is displayed
	And Select your type of organization as 'I am a supplier'
	And Select your buisness as "Contractor"
	And Enter your personnel as "50"
	And Select your buisness annual turnover as "£100,000 - £199,999"
	And Select your membership level as "Silver"
	And Add accliam to service "true" 
	When Click on your details link
	Then Verify that your details page is being displayed

	Scenario: example for data table by dictionary(vertical format)
	Given Construction online home page is launched
	When fill below information by Dictionary
	| Key             | Value   |
	| UserName        | a       |
	| Password        | 123     |



	Scenario: example for data table by CreateInstance(vertical format)
	Given Construction online home page is launched
	When fill below information by CreateInstance
	| Field           | Value   |
	| UserName        | a       |
	| Password        | 123     |



	Scenario: example for data table by Specflow Createset(horizontal format)
	Given Construction online home page is launched
	When fill below information by CreateSet
	| userName | Password |
	| a        | 123      |
	| b        | 234      |

	Scenario: example for data table by Dynamic set(horizontal format)
	Given Construction online home page is launched
	When fill below information by DynamicSet
	| userName | Password |
	| a        | 123      |
	| b        | 234      |