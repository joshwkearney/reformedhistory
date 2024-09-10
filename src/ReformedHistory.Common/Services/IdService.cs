namespace ReformedHistory.Common.Services;

public class IdService {
    private static readonly Random Random = new Random();

    public string GetUniqueId() {
        return "Component" + Random.NextInt64();
    }
}