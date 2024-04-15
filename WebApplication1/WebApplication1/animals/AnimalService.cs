namespace WebApplication1.animals;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;
    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animals> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public int CreateAnimal(Animals animals)
    {
        return _animalRepository.CreateAnimal(animals);
    }

    public Animals? GetAnimal(int id)
    {
        return _animalRepository.GetAnimal(id);
    }

    public int UpdateAnimal(Animals animals)
    {
        return _animalRepository.UpdateAnimal(animals);
    }

    public int DeleteAnimal(int id)
    {
        return _animalRepository.DeleteAnimal(id);
    }
}