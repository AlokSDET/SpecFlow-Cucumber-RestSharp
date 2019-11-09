Feature: Registration By example Specflow feature
	This functionality covers tests for registration with construction online website by example keyword


Scenario Outline:  Choose Your plan by different combinations
Given Construction online home page is launched
	And  Register Now link is being displayed
	When Click on Register now link
	Then Verify that it takes to the sign up for contruction page
	When Plan selection page is displayed
	And Select your type of Buisness as <Organization>
	And Select your type as <Buisness>
	And Enter your No of personnel as <Personnel>
	And Select your annual turnover as <AnnualTurnover>
	And Select your membership as <MemberShipLevel>
	And If plan is silver then Add or remove accliam accredition to service <AcclaimStatus>
	And If plan is gold then choose deemed to satisfy or Acclaim <Acclaim / Deemed To Satisfy>
	When Click on your details link
	Then Verify that your details page is being displayed

	Examples: 
	| Organization    | Buisness           | Personnel | AnnualTurnover          | MemberShipLevel | AcclaimStatus | Acclaim / Deemed To Satisfy |
	| I am a supplier | Contractor         | 50        | £100,000 - £199,999     | Silver          | True          | ""                          |
	| I am a supplier | Consultant         | 70        | £350,000 - £699,999     | Associate       | ""            | ""                          |
	| I am a supplier | Materials Supplier | 90        | £6,000,000 - £9,999,999 | Platinum        | ""            | ""                          |
	| I am a supplier | Contractor         | 30        | £1,500,000 - £2,499,999 | Gold            | ""            | Deemed To Satisfy           |
	| I am a supplier | Consultant         | 10        | £50,000,000 & above     | Gold            | ""            | Acclaim                     |
