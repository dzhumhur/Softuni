namespace WcfServiceDistanceCalculator
{
    using System.Drawing;
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDistanceCalculator" in both code and config file together.
    [ServiceContract]
    public interface IServiceDistanceCalculator
    {
        [OperationContract]
        double CalcDistance(Point startPoint, Point endPoint);
    }
}
