
Partial views in ASP.NET Core MVC are used to encapsulate and render reusable pieces of user interface 
(UI) code. They help in modularizing the UI and promoting code reuse by allowing you to define a 
portion of a view that can be included in multiple parent views. Partial views are particularly 
useful for rendering shared content such as navigation menus, headers, footers, and other UI 
components.

CREATING PARTIAL VIEW

1. Create the Partial View:

	- Add New Item on `Views` Folder or a specific view folder (e.g., `Views/Shared`).
	- Choose `MVC View Page` and name it (e.g., `_MyPartialView.cshtml`).
	- The underscore is common convention for naming partial views.

2. Define the Content:

	- Add the HTML and Razor syntax for the UI component you want to reuse.


RENDERING PARTIAL VIEW

	- You can render partial views in parent views using the `Partial` or `RenderPartial` methods.


`Partial` vs `RenderPartial` Methods

	- `Partial` method returns an `IHtmlContent` which you can render directly in a Razor view.

	- `RenderPartial` method writes directly to the output stream and is slightly more efficient.


PASSING DATA TO PARTIAL VIEW

	- You can pass data to partial views using view models or the `ViewData` dictionary.

	1. Using View Models

	2. Using ViewData


