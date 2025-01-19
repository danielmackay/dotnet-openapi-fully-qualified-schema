using Microsoft.OpenApi.Models;

namespace WebApi.Extensions;

public static class OpenApiExt2
{
    public static void AddOpenApiExt(this IServiceCollection services)
    {
        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer(async (document, context, ct) =>
            {
                await Task.CompletedTask;
            });

            options.AddOperationTransformer(async (operation, context, ct) =>
            {
                await Task.CompletedTask;
            });

            options.AddSchemaTransformer(async(schema, context, ct) =>
            {
                // schema.Type = context.JsonTypeInfo.Type.FullName;
                schema.Description = context.JsonTypeInfo.Type.FullName;
                schema.Title = context.JsonTypeInfo.Type.FullName;
                schema.Reference = new OpenApiReference
                {
                    Id = context.JsonTypeInfo.Type.FullName,
                    Type = ReferenceType.Schema,

                };
                await Task.CompletedTask;
            });


        });
    }
}
