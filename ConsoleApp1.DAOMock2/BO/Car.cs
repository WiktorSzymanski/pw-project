using ConsoleApp1.Core;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.DAOMock2.BO;

public class Car: ICar
{
    public int ID { get; set; }
    public string Name { get; set; }
    public IProducer Producer { get; set; }
    public int ProductionYear { get; set; }
    public TransmissionType Transmission { get; set; }
}