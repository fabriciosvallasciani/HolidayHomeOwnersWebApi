# HolidayHomeOwnersWebApi
## Technical assessment

### Foreword

1.- Create a simple Web API that can operate on Holiday Homes data for a specific Holiday Home Owner. 

* Holiday Home Owner - an entity that owns Holiday Home(s)
* Holiday Home - single property that can be rented out

2.- Create a simple Vue.js or React.js Web app that can consume the Web API and:

* List Owners
* List Properties when Owner selected
* CRUD operations for Owner and Holiday Home

3.- Bonus:

* Add authentication (BASIC auth) to the Web API, so the Web App cannot consume the API without being authenticated

### Requirements

* Create a public repository on GitHub and share the link by sending it to my email

### Acceptance criteria

* [ASP.NET](http://asp.net/) Web API or [ASP.NET](http://asp.net/) Core API (DONE)
* Responses should be in application/json content type (DONE)
* Entity Framework or EF Core for Entity persistence (DONE)
* One to many relationship between holiday homeowner and holiday homes (one owner can have zero or many holiday homes)
* GET all holiday homeowners endpoint (DONE)
* CRUD endpoints for Holiday Homes (DONE)
* It should not be possible to create a Holiday Home with owner id that does not exist (DONE)

Bonus:

* Demonstrate indentation of Sass in Web App
* Demonstration of mixins and functions in Sass in Web App
* BASIC auth authentication implemented (DONE)
* GET holiday homes by owner id with paging endpoint (should return 5 holiday homes at a time)
* Unit tests for covering the paging functionality 
