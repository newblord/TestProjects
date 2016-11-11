The following are the features that need to be implemented for Unit of Work Project:

	1)	  Clean TT Files
		   - Done
	2)   Add Model Interface support
			- Done
	3)   Add Repository Interface support
			- Done
	4)   Add Data Annotation support to Model classes
			- Done
	5)   Add switch to generate either Configuration or use Data Annotation for Model classes
			- Done
	6)   Data Annotation validations for Model Interfaces
			- Might not need this for future implementation
	7)   Add Repository support
			- Add CRUD methods - Done
			- Add FindBy methods for Primary Keys - Done
			- Add FindBy methods for Foreign Keys - Done
			- Add FindBy methods for Indexes - Done
			- Convert Reverse Navigation Properties on Models to methods on Repositories
				- Maybe use a flag for or setting for this - Done
	8)   Add proper Entity Framework Add/Attach/Entity support to Repository files
	9)   Add Custom Property change management for Model classes
			- Might be be able to piggy back on EF property management
	10)  Add support for Entity Framework Entity Graph management
	11)  Add Enum support
			- Add support to manually match enum to properties on tables
	12)  Refactor Database Reverse Engineering for mass table generation
			- Done with partial testing
			- Takes about 40 seconds to generate all files
	13)  Refactor UpdateFromDatabase WinForm
			- Recreate Tables tab - Done
			- Recreate Stored Procedure Tab - Done
			- Add tab for Database Generation Settings - Done
			- Add Settings to xml file - Done
	14)  Add DTO file creation
			- Done
	15)  Add Business Service and IBusinessService for tables
			- Standard methods from Repository need to be Implemented - Done
	16)  Business Specification Files
			- Done
	17)  Complete Unit Of Work Design Pattern
	18)  Add IOC or Dependency Injection
	19)  When GenerateContext is disabled switch to ADO.NET Connection to database instead of Entity Framework
	20)  Fix ForeignKey Relationship mapping
			- This will affect ReverseNavigation Properties on Table and Column
			- Entity Framework Core has better Relationship mapping between tables
			