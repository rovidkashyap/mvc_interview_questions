
Sessions in ASP.NET Core MVC are used to store user data while the user is browsing a web application. 
Unlike cookies, which are stored on the client side, session data is stored on the server side. 

This can be useful for storing sensitive information that you do not want to expose to the client or 
for storing larger amounts of data than would be practical with cookies.

Enabling and Configuring Session in ASP.NET Core MVC

To use sessions in an ASP.NET Core MVC application, you need to configure the session middleware in 
your `Program.cs` file.

STEP 1 - Add Session Services

	- First, add session services to the service collection in the `Program.cs` file.

STEP 2 - Use Session Middleware

	- Next, use the session middleware in the `Program.cs` method to enable session handling.

Using Session in Controllers

	- Setting Session Data
		- To store data in the session, use the `HttpContext.Session` property.
		- Check the `HomeController` file.

	- Getting Session Data
		- To remove the data from the session, use the `HttpContext.Session.Remove` method.


SUMMARY

- Enabling Sessions: Configure session services and middleware in Startup.cs.

- Setting Data: Use HttpContext.Session.SetString and HttpContext.Session.SetInt32 to store data.

- Getting Data: Use HttpContext.Session.GetString and HttpContext.Session.GetInt32 to retrieve data.

- Removing Data: Use HttpContext.Session.Remove to remove specific items or HttpContext.Session.Clear 
				 to clear all session data.
