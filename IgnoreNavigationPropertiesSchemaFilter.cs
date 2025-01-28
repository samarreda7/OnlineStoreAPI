using Microsoft.OpenApi.Models;
using OnlineStoreAPI.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class IgnoreNavigationPropertiesSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type == typeof(Product))
        {
            // Remove the `Category` property
            schema.Properties.Remove("category");
        }
    }
}