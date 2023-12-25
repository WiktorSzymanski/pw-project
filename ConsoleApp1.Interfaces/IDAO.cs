namespace ConsoleApp1.Interfaces;

public interface IDAO
{
    IEnumerable<IProducer> GetAllProducers();
    IEnumerable<ICar> GetAllCars();

    IProducer CreateNewProducer();
    ICar CreateNewCar();
}