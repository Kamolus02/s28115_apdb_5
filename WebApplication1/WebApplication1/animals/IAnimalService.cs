namespace WebApplication1.animals;

public interface IAnimalService
{
    IEnumerable<Animals> GetAnimals();

    int CreateAnimal(Animals animal);

    Animals? GetAnimal(int idAnimal);

    int UpdateAnimal(Animals animals);

    int DeleteAnimal(int idAnimal);
}