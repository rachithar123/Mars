Feature: Skills
		 As a Seller
		 I want to be able to complete my Skills section of Profile
		 So that anyone can view my updations of Skills


@mytag
Scenario: Add New Skills to Profile Details
	Given The seller is on the Profile details page to Add New skills 
	When  The seller enters skill
	And select the skill level
	| Add Skill		|  | Choose Skill Level		|
	| Baking		|  | Expert					|
	Then it should dispaly message"Baking has been added to your skills"

@mytag
Scenario: Add skills to the profile detail page using special characters 
	Given The seller is on the Profile details page to Add New skills 
	When  The seller enter skill
	And select skill level
	| Add Skill |  | Choose Skill Level |
	| Baking    |  | Expert             |
	| @@@@@@@   |  | Beginner           |
	Then it should dispaly message"@@@@@@@  has been added to your skills"

@mytag
Scenario: Add skills to the Profile Details page using numeric characters 
	Given The seller is on the Profile details page to Add New languages 
	When The seller enter skill
	And  select skill level
	| Add Skill |  | Choose Skill Level |
	| Baking    |  | Expert             |
	| @@@@@@@   |  | Beginner           |
	| 12345     |  | Beginner           |
   Then it should dispaly message"12345   has been added to your languages"

@mytag
Scenario: Update Exsisting skills on Profile Details
	Given The Seller is on the Profile page to update only skills details 
	When  The seller updates skills
	| Add Skill			  |  | Choose Skill Level |
	| Baking & cooking    |  | Expert             |
	| @@@@@@@             |  | Beginner           |
	| 12345               |  | Beginner           |
	Then it should display message "Baking & cooking" has been updated in your skills

@mytag
Scenario: Update level of Exsisting skills on Profile Details
	Given The Seller is on the Profile page to update only skills level
	When  The seller updates level of skill
	| Add Skill			  |  | Choose Skill Level	  |
	| Baking & cooking    |  | Expert				  |
	| @@@@@@@             |  | Beginner				  |
	| 12345               |  | intermediate           |
	Then it should display message " Baking & cooking" has been updated in your skills
	
@mytag
Scenario: Delete  skills from Profile Details
	Given The Seller is on the Profile page to delete the skills
	| Add Skill			  |  | Choose Skill Level	  |
	| Baking & cooking    |  | Expert				  |
	| @@@@@@@             |  | Beginner				  |
	| 12345               |  | intermediate           |
	When  The seller delete the skills
	| Add Skill			  |  | Choose Skill Level	  |
	| Baking & cooking    |  | Expert				  |
	| 12345               |  | intermediate           |         
	Then  it should display message "@@@@@@" has been deleted from your Languages



@mytag	
Scenario: Add Same skills to the Profile Details
	Given The seller is on the Profile details page to Add same skills 
	When  The seller enter same skill
	| Add Skill			  |  | Choose Skill Level	  |
	| Baking & cooking    |  | Expert				  |        
    Then It should display the message "Duplicate data"

@mytag
Scenario: Keeps the blank data feilds on Profile Details
	Given The seller is on profile details page to keep skills field blank
	When  The seller keep blank feilds
	| Add Skill			  |  | Choose Skill Level	  |
	| Baking & cooking    |  | Expert				  |
	|		              |  | intermediate           |    
	Then It should dispaly the message"Please enter skills and experience level"
