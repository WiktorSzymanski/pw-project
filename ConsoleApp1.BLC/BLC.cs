using ConsoleApp1.Interfaces;
using System.Reflection;

namespace ConsoleApp1.BLC;

public class BLC
{
    private IDAO _dao;

    public BLC(string liblaryName)
    {
        Assembly assembly = Assembly.UnsafeLoadFrom(liblaryName);

        Type typeToCreate = null;

        foreach (Type t in assembly.GetTypes())
        {
            if (t.IsAssignableTo(typeof(IDAO)))
            {
                typeToCreate = t;
                break;
            }
        }

        _dao = (IDAO)Activator.CreateInstance(typeToCreate, null);
    }

    public IEnumerable<IProducer> GetProducers() => _dao.GetAllProducers();
    public IEnumerable<ICar> GetCars() => _dao.GetAllCars();
}