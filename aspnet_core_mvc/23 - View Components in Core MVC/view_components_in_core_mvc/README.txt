
View Components in ASP.NET Core MVC are a feature that allows you to encapsulate and reuse rendering 
logic, similar to partial views but with more powerful capabilities. 

They help in creating reusable, testable components that can render HTML and perform any necessary 
processing independently of the controller.

Key Features of View Components

1. Reusable: View Components can be used across multiple views, promoting DRY (Don't Repeat Yourself)
			 principles.

2. Encapsulated Logic: They contain both the rendering logic and any required processing logic.

3. Testable: View Components can be unit tested independently of the MVC pipeline.

4. No Dependency On Controllers: They can be invoked directly from views or other components without
								 relying on a controller action.


Creating and Using View Components

1. Creating a View Component Class
2. Creating a View Component View
3. Invoking a View Component