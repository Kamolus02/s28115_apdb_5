namespace WebApplication1.animals;

public interface IAnimalRepository
{
    IEnumerable<Animals> GetAnimals();

    int CreateAnimal(Animals animals);

    Animals GetAnimal(int id);

    int UpdateAnimal(Animals animals);
    
    int DeleteAnimal(int id);
}