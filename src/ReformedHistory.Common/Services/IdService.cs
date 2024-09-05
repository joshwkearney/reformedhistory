namespace ReformedHistory.Common.Services;

public class IdService {
    private int counter = 0;

    public string GetUniqueId() {
        return "Component" + this.counter++;
    }
}