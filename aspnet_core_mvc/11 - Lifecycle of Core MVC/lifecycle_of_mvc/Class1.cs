namespace lifecycle_of_mvc
{
    public class Class1
    {
        /*
         
            The lifecycle of an ASP.NET Core MVC application involves several key stages, from 
            initialization to the final response being sent back to the client. Understanding this 
            lifecycle is crucial for developers to effectively manage and optimize their web 
            applications. Here is an overview of the ASP.NET Core MVC application lifecycle: 
        
            1. Application Initialization ----------------

                - `Program.cs` File - This is entry point of ASP.Net Core application. This file
                   Contains `Main` method, which configures and runs the web host.

            2. Configuration and Service Registration (In .Net Core 6+ Startup.cs file is removed)

                - `Startup.cs` File - where services are registered and the application's request
                   pipeline is configured. This file contains two methods `ConfigureServices` and
                   `Configure`.

                    - `ConfigureServices` - is used to register services with dependency injection
                                            container.

                    - `Configure` - is used to define the middleware components that handle HTTP 
                                    requests.

            3. Middleware Pipeline ------------------------

                - This components handle HTTO requests. Each component can handle the request or
                  pass it to the next component in the pipeline. Some common middleware components:

                    - Static Files Middleware - Serves static files like images, CSS and JavaScript.
                    - Routing Middleware - Routes the request to appropriate endpoint.
                    - Authentication and Authorization Middleware - handle user authentication/auth.
                    - MVC Middleware - processes MVC requests and responses.

            4. Routing ------------------------------------

                - Routing determine how HTTP requests mapped to the controller actions. Routes are 
                  defined using `Endpoints` method in `Configure` method of `Startup.cs` file.

            5. Model Binding ------------------------------

                - It is process of mapping HTTP request data to action method parameters. ASP.Net Core
                  MVC supports Model Binding for various data source, including query string from data,
                  route data and JSON payloads.

            6. Action Execution

                - Once routing determine the appropriate controller and action method, the action method
                  is executed. This involves:

                    - Executig Filters: Filters are executing before and after action method.
                    - Executing Action Method: it processes the request and returns an `IActionResult`.
         
            7. Result Execution

                - The `IActionResult` returned by the action method is processed to generate the 
                  HTTP response. Common action results include:
                
                    - ViewResult : Renders a View
                    - JsonResult : Render a JSON data
                    - RedirectResult : Redirects to another action or URL
                    - ContentResult : Returns plain text content.

            8. Sending Response

                - Finally, the processed result in written to the HTTP response and sent back to the
                  clients. This marks the end of the request lifecycle.
         
        */
    }
}
