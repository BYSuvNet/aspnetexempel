public class MyService : IMyService
{
    public List<string> GetData()
    {
        return new List<string> { "Data1", "Data2", "Data3" };
    }
}

public interface IMyService
{
    List<string> GetData();
}
