Frontend application is developed using Angular 14 framework.
Backend application is developed using .NET 6 framework.

In order to run backend application, you need to add API key for All The Clouds HTTP API using Secret manager tool:
<ol>
  <li>Run the following command from /Poducts-service/Poducts-service/ directory: <code>dotnet user-secrets set "HttpConfiguration:ApiKey" "{API KEY value}"</code>. Value should be API key. Due to security reasons, API key is not stored on Github.</li>
  <li>For more information regarding Secret manager tool, visit <a href="https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#set-a-secret">this link</a>
</ol>
