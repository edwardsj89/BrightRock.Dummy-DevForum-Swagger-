Add swashbuckle
 - Install-Package swashbuckle
 
Modify SwaggerConfig class
 - Remove PreApplicationStartMethod Attribute
 - add parameter to Register method (HttpConfiguration config)
 - change GlobalConfiguration.Configuration to use the config parameter
 - Modify root Url => c.RootUrl(req => req.RequestUri.GetLeftPart(UriPartial.Authority) + req.GetRequestContext().VirtualPathRoot.TrimEnd('/'));
 
Modify Startup class
 - add SwaggerConfig.Register(config); //Move to top (Above where routes are registered)
 
To navigate to Swagger UI
 - BaseUrl + /swagger ##/ui/index
Swagger docs
 - BaseUrl + /swagger/docs/v1

**Note**
SwaggerConfig.Register must appear before WebApiConfig.Register(config);