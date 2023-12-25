using ConsoleApp1.Core;
namespace ConsoleApp1.Interfaces;

public interface ICar
{
    int ID { get; set; }
    string Name { get; set; }
    IProducer Producer { get; set; }
    int ProductionYear { get; set; }
    TransmissionType Transmission { get; set; }
}