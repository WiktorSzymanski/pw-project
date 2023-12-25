using ConsoleApp1.Interfaces;

namespace ConsoleApp1.DAOMock1;

public class DAOMock: IDAO
{
    private List<IProducer> _producers;
    private List<ICar> _cars;

    public DAOMock()
    {
        _producers = new List<IProducer>()
        {
            new BO.Producer() { ID = 1, Name = "Toyota" },
            new BO.Producer() { ID = 2, Name = "Subaru" }
        };

        _cars = new List<ICar>()
        {
            new BO.Car()
            {
                ID = 1,
                Producer = _producers[0],
                Name = "Yaris",
                ProductionYear = 2018,
                Transmission = Core.TransmissionType.Manual
            },
            new BO.Car()
            {
                ID = 2,
                Producer = _producers[0],
                Name = "Corolla",
                ProductionYear = 2020,
                Transmission = Core.TransmissionType.Automatic
            },
            new BO.Car()
            {
                ID = 3,
                Producer = _producers[1],
                Name = "Forester",
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