namespace ReformedHistory.Common.Services;

public class IdService {
    public string GetUniqueId() {
        return "Component" + Random.Shared.NextInt64();
    }
}