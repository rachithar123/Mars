Feature: Education
		As a Seller
		I want to be able to complete my Education section of Profile
		So that anyone can view my updations of Education


@mytag
Scenario: Add New Education qualification to Profile Details
	Given The seller is on the Profile details page to Add New Educations
	When  The seller enters Collage/University name ,Degree
	And   select the Country of College ,Title ,Year of graduation
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- degree |  | 2021               |
	Then it should dispaly message"Unitec  has been added to your skills

@mytag
Scenario: Add Education qualification to the profile detail page using special characters 
	Given The seller is on the Profile details page to Add New Education qualification 
	When  The seller enters Collage/University name ,Degree
	And   select the Country of College ,Title ,Year of graduation
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	| %^&*                    |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- degree |  | 2021               |
	Then it should dispaly message"Education has been added"

@mytag
Scenario: Add Edcation to the Profile Details page using numeric characters 
	Given The seller is on the Profile details page to Add New Education
	When  The seller enters Collage/University name ,Degree
	And   select the Country of College ,Title ,Year of graduation
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	| %^&*                    |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- degree |  | 2021               |
	| 12345                   |  |2343523 |  | NZ                 |  | IT- degree |  | 2021               |
   Then it should dispaly message"Education has been added"

@mytag
Scenario: Update Exsisting Education on Profile Details
	Given The Seller is on the Profile page to update only Education details 
	When  The seller enters Collage/University name ,Degree
	And   select the Country of College ,Title ,Year of graduation
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	|zanh23@                  |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- degree |  | 2021               |
	| 12345                   |  |2343523 |  | NZ                 |  | IT- degree |  | 2021               |
	Then it should display message "Education has been updated"

@mytag
Scenario: Update Title,year of Exsisting Education on Profile Details
	Given The Seller is on the Profile page to update only Ttile,year details 
	When  The seller enters Collage/University name ,Degree
	And   select the Country of College ,Title ,Year of graduation
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	|zanh23@                  |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- Deploma|  | 2020               |
	| 12345                   |  |2343523 |  | NZ                 |  | IT- degree |  | 2021               |
	Then it should display message "Education has been updated"
	
@mytag
Scenario: Delete  Education from Profile Details
	Given The Seller is on the Profile page to delete the Education
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	|zanh23@                  |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- Deploma|  | 2020               |
	| 12345                   |  |2343523 |  | NZ                 |  | IT- degree |  | 2021               |
	When  The seller delete the Education
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	|zanh23@                  |  | %&*&   |  | NZ                 |  | IT- degree |  | 2021               |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- Deploma|  | 2020               |
	Then  it should display message "Education has been deleted"

	

@mytag	
Scenario: Add Same Education to the Profile Details
	Given The seller is on the Profile details page to Add same Education
	When  The seller enter same Education details
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- Deploma|  | 2020               |
    Then It should display the message "Duplicate data"

@mytag
Scenario: Keeps the blank data feilds on Profile Details
	Given The seller is on profile details page to keep Education fields blank
	When  The seller keep blank feilds
	| Collage/University name |  | Degree |  | Country of College |  | Title      |  | Year of Graduation |
	|                         |  | %&*&   |  |                    |  | IT- degree |  |                    |
	| Unitec                  |  | B.Sc   |  | NZ                 |  | IT- Deploma|  | 2020               | 
	Then It should dispaly the message"Please enter all details"
