
In ASP.NET Core MVC, filters are used to run code before or after specific stages in the request 
processing pipeline. They are a powerful feature that allows you to encapsulate cross-cutting concerns, 
such as logging, authentication, and authorization, into reusable components. 

Filters can be applied globally, to controllers, or to individual actions.

Types of Filters

	1.Authorization Filters:

		- Run first and determine whether the current user is authorized for the current request.
		- Example: [Authorize]

	2. Resource Filters:

		- Run after authorization and are useful for handling caching or other resource-related tasks.
		- Example: Implementing a custom resource filter to manage resource access.

	3. Action Filters:

		- Run before and after an action method execution.
		- Example: Logging action method execution or modifying the action result.

	4. Exception Filters:

		- Run after an action method throws an exception.
		- Example: Custom error handling and logging.

	5. Result Filters:

		- Run before and after the execution of action results.
		- Example: Modifying the response or logging the result execution.