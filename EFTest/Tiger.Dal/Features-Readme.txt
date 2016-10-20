The following are the features that need to be implemented for Unit of Work Project:

	1)	  Clean TT Files
		   - Done
	2)   Add POCO Interface support
			- Done
	3)   Add Repository Interface support
			- Done
	4)   Add Data Annotation support to POCO classes
			- Done
	5)   Add switch to generate either Configuration or use Data Annotation for POCO classes
			- Done
	6)   Data Annotation validations for POCO Interfaces
			- Might not need this for future implementation
	7)   Add Repository support
			- Add CRUD methods - Done
			- Add FindBy methods for Primary Keys - Done
			- Add FindBy methods for Foreign Keys - Done
			- Add FindBy methods for Indexes - Done
			- Convert Reverse Navigation Properties on POCOs to methods on Repositories
				- Maybe use a flag for or setting for this
	8)   Add proper Entity Framework Add/Attach/Entity support to Repository files
	9)   Add Custom Property change management for POCO classes
			- Might be be able to piggy back on EF property management
	10)  Add support for Entity Framework Entity Graph management
	11)  Add Enum support
			- Add support to manually match enum to properties on tables
	12)  Refactor Database Reverse Engineering for mass table generation
			- Done with partial testing
			- Takes about 40 seconds to generate all files
	13)  Refactor UpdateFromDatabase WinForm
			- Recreate Tables tab - Done
			- Recreate Views Tab
			- Recreate Stored Procedure Tab
			- Add tab for Database Generation Settings - Done
			- Add Settings to xml file - Done
	14)  Add DTO file creation
	15)  Add Business Service and IBusinessService for tables
			- Try to create Business Service for only main tables
				- ex: Loan Application has several tables that extend the main LoanApplication table, 
						the Business Service would only be generated for the main LoanApplication table
						and the repositories for the other tables will be added as properties or using IOC
	16)  Complete Unit Of Work Design Pattern
	17)  Add IOC or Dependency Injection
	18)  When GenerateContext is disabled switch to ADO.NET Connection to database instead of Entity Framework
	19)  Fix ForeignKey Relationship mapping
			- This will affect ReverseNavigation Properties on Table and Column
			