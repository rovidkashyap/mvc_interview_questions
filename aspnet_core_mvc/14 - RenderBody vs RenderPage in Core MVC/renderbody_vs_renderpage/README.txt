
In ASP.NET Core MVC, RenderBody() and RenderPage() are methods used within layout files to include and 
render content from other views. They serve different purposes and are used in different scenarios. 

Here is an explanation of each method and the differences between them:

`RenderBody()` -

`RenderBody()` is used in a layout page to render the content of the child view. The layout page defines 
a common structure for multiple views, such as a header, footer, and navigation, and RenderBody() 
specifies where the content of the individual view should be placed within that structure.

	- For Example, See the _Layout.cshtml file of this project in `/Views/Shared/_Layout.cshtml` file.

`RenderPage()` -

`RenderPage()` is used to render content from another view within the current view. It can be used to 
include reusable content, such as partial views or other Razor pages, within a layout or another view.

	- For Example, See the _Layout.cshtml file of this project in `/Views/Shared/_Layout.cshtml` file.