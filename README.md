# odata
MVC ODATA Sample Project

MVC Odata sample project that is built by creating a new ASP.NET MVC empty project.

##Create the solution
Create a new solution following File -> New -> Project -> Web, then choose ASP.NET Web Application. Name it with odata. Then in the upcoming dialogue box, choose Empty and check Web API, click OK.

##Install NuGet packages
Run the following command in the Package Manager Console.

PM> Install-Package Microsoft.AspNet.OData

##Add Models
In Models folder, I added User.cs and Address.cs

##Add Controller
In Controllers folder, I added UsersController.cs. This inherits from ODataController that defines a base class for OData controllers that support writing and reading data using the OData formats.

##Modify WebApiConfig.cs
In App_Start fodler, I modified WebApiConfig controller.

##Try with it
You can try it out now! All samples below are all GET method.

###Service document
http://localhost:[portNumber]/

###Service metadata
http://localhost:[portNumber]/$metadata

###Get Users
http://localhost:[portNumber]/Users

###Queries
http://localhost:[portNumber]/Users?$select=FirstName,LastName<br />
http://localhost:[portNumber]/Users?$expand=Address<br />
http://localhost:[portNumber]/Users?$$filter=contains(FirstName,"Yas")

##For More information
http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html<br />
http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part2-url-conventions.html

