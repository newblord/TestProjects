The following are the features that need to be implemented for Database Generation Tool:

	
- Data Annotation validations for Model Interfaces
    - Might not need this for future implementation
- Add proper Entity Framework Add/Attach/Entity support to Repository files
- Add Custom Property change management for Model classes
	- Might be be able to piggy back on EF property management
- Add support for Entity Framework Entity Graph management
- Add support to manually match enum to properties on tables
    - Currently Working on this.
- Complete Unit Of Work Design Pattern
- Add IOC or Dependency Injection
- When GenerateContext is disabled switch to ADO.NET Connection to database instead of Entity Framework
- Fix ForeignKey Relationship mapping
	- This will affect ReverseNavigation Properties on Table and Column
	- Entity Framework Core has better Relationship mapping between tables
- Proper Error Handling for Tool
- Create Custom Enum Constraint in code 
    - This will allow us to create in code check to see if the enum value set is one that is valid