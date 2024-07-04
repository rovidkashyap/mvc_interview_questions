
An anti-forgery token in ASP.NET Core MVC is a security feature used to protect web applications from 
Cross-Site Request Forgery (CSRF) attacks. CSRF is an attack where a malicious actor tricks a user 
into performing actions they did not intend to perform on a different site where they are authenticated.

How Anti-Forgery Tokens Work

1. Generation:
	
	- When a form is rendered on the client side, an nti-forgery token is generated and included in the 
	  form as a hidden field.

	- Additionally, a corresponding token is stored in a cookie.

2. Validaton:

	- When the form is submitted, the token in the hidden field and the token in the cookie are both 
	  sent to the server.

	- The server then validates that both tokens match and are legitimate before processing the request.

	- If the tokens do not match, the server rejects the request as a potential CSRF attack.

Implement Anti-Forgery Tokens

1. Adding Anti-Forgery Tokens to Forms
	
	- To include an anti-forgery token in a form, use the `@Html.AntiForgeryToken()` helper method
	  in your Razor view.

2. Validating Anti-Forgery Tokens in Controllers

	- To validate the anti-forgery token, use the [ValidateAntiForgeryToken] attribute on your 
	  controller action: