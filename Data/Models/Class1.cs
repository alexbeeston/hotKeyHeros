namespace HotKeyHeros.Data.Models;

public class DataCollectionEntity
{
    public int Id { get; set; }

    public DateTime UtcStart { get; set; }

    public DateTime UtcEnd { get; set; }

    public int NumKeyStrokes { get; set; }

    public int NumMouseClicks { get; set; }
}
