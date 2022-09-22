In order to run backend application, you need to add API KEY using Secret manager tool:
<ol>
  <li>Run following command <code>dotnet user-secrets set "HttpConfiguration:ApiKey" "{API KEY value}"</code>. Value should be API_KEY for All The Clouds HTTP API</li>
  <li>For more information regarding Secret manager tool, visit <a href="https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#set-a-secret">this link</a>
</ol>
