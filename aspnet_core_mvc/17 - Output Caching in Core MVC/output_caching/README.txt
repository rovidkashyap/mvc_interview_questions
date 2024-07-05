
Output caching in ASP.NET Core MVC is a performance optimization technique that stores the generated 
output of a controller action in memory so that subsequent requests for the same resource can be 
served faster. 

This helps reduce server load and improves response times by eliminating the need to re-execute the 
action and regenerate the same content.

Implementing Output Caching in ASP.Net Core MVC

	- In ASP.Net Core, output caching is manages using response caching middleware and attributes.


Step 1: Configure Middleware -

	- First you need to configure the response caching middleware in the `Program.cs` file.

Step 2: Use ResponseCache Attribute -

	- Basic Output Caching -

			- Apply the `[ResponseCache]` attribute to controller actions or controllers to specify caching
			 behavior.

	- Caching with Custom Headers -
			
			- Different cached versions are maintained based on the `User-Agent` header.
	
	
	Cache Profiles

		- You can define cache profiles in the `Program.cs` file and reuse them across multiple actions.
		
		- Define Cache Profiles in `Program.cs` file.