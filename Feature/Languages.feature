Feature: Languages
	     As a Seller
		 I want to be able to complete my Language section of Profile
		 So that anyone can view my updations of Language/s


@mytag
Scenario: Add New Languages to Profile Details
	Given The seller is on the Profile details page to Add New languages 
	When  The seller enters language
	And select the language level
	| Add Language	|  | Choose Language Level  |
	| English		|  | Conversional			|
	| Sinhala		|  | Fluent					|
	Then it should dispaly message"English has been added to your languages"

@mytag
Scenario: Add Languages to the profile detail page using special characters 
	Given The seller is on the Profile details page to Add New languages 
	When  The seller enter language
	And select language level
	| Add Language	|  | Choose Language Level  |
	| English		|  | Conversional			|
	| @#!@#$		|  | Basic					|
	Then it should dispaly message"@#!@#$  has been added to your languages"

@mytag
Scenario: Add Language to the Profile Details page using numeric characters 
	Given The seller is on the Profile details page to Add New languages 
	When The seller enter language
	And select language level
	| Add Language |  | Choose Language Level |
	| English      |  | Conversional          |
	| @#!@#$       |  | Basic                 |
	| 12345        |  | Basic                 |
   Then it should dispaly message"12345   has been added to your languages"

@mytag
Scenario: Update Exsisting Languages on Profile Details
	Given The Seller is on the Profile page to update only language details 
	When  The seller updates languages
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Conversional          |
	| @#!@#$       |  | Basic                 |
	| 12345        |  | Basic                 |
	Then it should display message "Spanish" has been updated in your Languages

@mytag
Scenario: Update level of Exsisting Languages on Profile Details
	Given The Seller is on the Profile page to update only language level
	When  The seller updates level of language
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Fluent				  |
	| @#!@#$       |  | Basic                 |
	| 12345        |  | Basic                 |
	Then it should display message "Spanish" has been updated in your Languages
	
@mytag
Scenario: Delete  Language from Profile Details
	Given The Seller is on the Profile page to delete the languages
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Fluent				  |
	| @#!@#$       |  | Basic                 |
	| 12345        |  | Basic                 |
	When  The seller delete the language
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Fluent				  |
	| @#!@#$       |  | Basic                 |          
	Then  it should display message "12345" has been deleted from your Languages


@mytag	
Scenario: Add Same language to the Profile Details
	Given The seller is on the Profile details page to Add same language 
	When  The seller enter same language
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Fluent				  |
	| @#!@#$       |  | Basic                 |     
    Then It should display the message "Duplicate data"

@mytag
Scenario: Keeps the blank data feilds on Profile Details
	Given The seller is on profile details page to keep language field blank
	When  The seller keep blank feilds
	| Add Language |  | Choose Language Level |
	| Spanish      |  | Fluent                |
	| @#!@#$       |  | Basic                 |
	|              |  | Basic                 |
	Then It should dispaly the message"Please enter language and level"
