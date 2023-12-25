using ConsoleApp1.Interfaces;

namespace ConsoleApp1.DAOMock2;

public class DAOMock2: IDAO
{
    private List<IProducer> _producers;
    private List<ICar> _cars;

    public DAOMock2()
    {
        _producers = new List<IProducer>()
        {
            new BO.Producer() { ID = 1, Name = "Ford" },
            new BO.Producer() { ID = 2, Name = "Mazda" }
        };

        _cars = new List<ICar>()
        {
            new BO.Car()
            {
                ID = 1,
                Producer = _producers[0],
                Name = "Focus",
                ProductionYear = 2018,
                Transmission = Core.TransmissionType.Manual
            },
            new BO.Car()
            {
                ID = 2,
                Producer = _producers[0],
                Name = "Mondeo",
                ProductionYear = 2020,
                Transmission = Core.TransmissionType.Automatic
            },
            new BO.Car()
            {
                ID = 3,
                Producer = _producers[1],
                Name = "CX-5",
                ProductionYear = 2016,
                Transmission = Core.TransmissionType.Manual
            }
        };
    }
    
    public IEnumerable<IProducer> GetAllProducers()
    {
        return _producers;
    }

    public IEnumerable<ICar> GetAllCars()
    {
        return _cars;
    }

    public IProducer CreateNewProducer()
    {
        return new BO.Producer();
    }

    public ICar CreateNewCar()
    {
        return new BO.Car();
    }
}