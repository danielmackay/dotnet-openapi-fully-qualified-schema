# .NET OpenAPI Fully Qualified Namespace

Attempt to reproduce an issue with .NET 9 OpenAPI & Scalar when DTOs with the same class name, but different namespace would cause a conflict.

When using swagger we would solve this by using the namespace to fully qualify the model name in the OpenAPI schema.

## Conclusion

With .NET 9 OpenAPI & Scalar, this is no longer an issue!

Two classes with the same name (i.e. `WeatherForecast`) will automatically have a number suffix added to avoid any conflict.

<img width="722" alt="image" src="https://github.com/user-attachments/assets/ccdaaff7-3b6b-4417-9247-dba7a1915e50" />
