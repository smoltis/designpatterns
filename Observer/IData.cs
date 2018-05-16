namespace Observer
{
    public interface IData
    {
        double Humidity { get; set; }
        double Pressure { get; set; }
        double Temp { get; set; }
    }
}