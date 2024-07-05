
State management in ASP.NET Core MVC involves preserving the state of an application across requests. 
Unlike traditional desktop applications, web applications are stateless by nature, meaning each 
request from the client to the server is independent. 

To maintain state, ASP.NET Core MVC provides several techniques:

1. Session State -

	- Session state is server-side management technique that allows you to store user data across 
	  requests. The session is unique per user and is maintained for the duration of user session.

2. TempData -

	- TempData is short-living state management mechanism used to store data temporarily. It is
	  particulary useful for passing data between actions.

3. ViewData and ViewBag -

	- ViewData and ViewBag are used to pass data from controller to views. ViewData is dictionary while
	  ViewBag is a dynamic property.

4. Cookies -

	- Cookies are small pieces of data stores on the client-side and sent to the server with each request
	  they are useful for storing small amount of data, such as user preferences.

5. Cache -

	- Caching is used to store data that is expensive to retrieve or compute. It improves performance by 
	  reducing the need to retrieve data from a slow resource.

	-  Configure `Caching` in `Program.cs` File.

		-	`services.AddMemoryCache();`

6. Hidden Fields -

	- Hidden fields can be used to store state information in forms. This is a client-side state 
	  management technique.

	- <input type="hidden" name="Field_Name" value="Field_value" />

Summary

1. Session State: For storing user-specific data across multiple requests.

2. TempData: For passing data between actions, typically for redirects.

3. ViewData and ViewBag: For passing data from controllers to views.

4. Cookies: For storing small amounts of data on the client-side.

5. Cache: For improving performance by storing expensive-to-retrieve data.

6. Hidden Fields: For storing state information in forms during postbacks.
