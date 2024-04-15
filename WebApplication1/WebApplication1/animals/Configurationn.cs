namespace WebApplication1.animals;

public static class Configurationn
{
    public static IEndpointRouteBuilder RegisterAnimalUserEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/animals", (IAnimalService service) => TypedResults.Ok(service.GetAnimals()));
        endpoints.MapGet("/animals/{id:int}",
            (int id, IAnimalService service) => TypedResults.Ok(service.GetAnimal(id)));
        endpoints.MapPost("/animals",
            (Animals animals, IAnimalService service) => TypedResults.Ok(service.CreateAnimal(animals)));
        endpoints.MapPut("/animals/{id:int}", (int id, Animals animals, IAnimalService service) =>
        {
            animals.id = id;
            service.UpdateAnimal(animals);
            return TypedResults.NoContent();
        });
        endpoints.MapDelete("/animals/{id:int}", (int id, IAnimalService service) =>
        {
            service.DeleteAnimal(id);
            return TypedResults.NoContent();
        });

        return endpoints;
    }
}