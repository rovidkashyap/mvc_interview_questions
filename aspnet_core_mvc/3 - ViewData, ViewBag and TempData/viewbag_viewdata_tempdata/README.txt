
In ASP.NET Core MVC, ViewData, ViewBag, and TempData are used to pass data between controllers and 
views. Each has its own purpose and use case. Here are the key differences:

ViewData

1. `ViewData` is a dictionary of key-value pairs derived from the ViewDataDictionary class.

2. It is used to pass data from the controller to the view. Data is stored as objects and must be cast 
   to the appropriate type when retrieved.

3. Data in `ViewData` is only available for the current request.

ViewBag

1. ViewBag is a dynamic property (an instance of the DynamicViewData class) that provides a more 
   flexible way to work with key-value pairs.

2. It is also used to pass data from the controller to the view. Unlike ViewData, ViewBag does not 
   require explicit casting.

3. Data in ViewBag is only available for the current request.

TempData

1. `TempData` is a dictionary derived from the TempDataDictionary class

2. It is used to pass data from one request to another, which is useful for redirect scenarios. 
   Data is stored as objects and must be cast to the appropriate type when retrieved.

3. Data in TempData is available for the current request and the subsequent request (after a redirect). 
   After it has been read, it is marked for deletion.