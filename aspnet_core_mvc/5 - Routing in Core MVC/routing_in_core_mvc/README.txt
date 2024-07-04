
Routing in ASP.NET Core MVC is the mechanism that maps incoming HTTP requests to the appropriate 
controller actions. It plays a crucial role in defining how URLs correspond to actions and how data 
is passed within the application. 

ASP.NET Core MVC supports both convention-based and attribute-based routing.

Key Concepts of Routing

1. Route Templates: Define Patterns for matching URLs to controller actions.

2. Route Parameters: Capture values from the URL and pass them to controller actions.

3. Default Routes: Provide default valies for route parameters if they are not present in the URL

4. Constraint: Restrict routes to match specific patterns.

5. Route Proprity: Routes are evaluate in the order they are added, with the first match being used.

Convention-Based Routing

	- Convention-based Routing is configured in the `Program.cs` file using the `UseEndpoints` methods.

Attribute-Based Routing

	- Attribute-Based Routing allows you to define routes directly on the controller and action methods
	  using attributes.