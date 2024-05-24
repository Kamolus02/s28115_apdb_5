namespace DefaultNamespace;
using FluentValidation;

public static class Validators
{
    public static void RegisterValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<AnimalReplaceRequestValidator>();
        services.AddValidatorsFromAssemblyContaining<AnimalCreateRequestValidator>();
    }
}