namespace GridFSCreateEditAndDisplay.Models
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string InfoCollectionName { get; set; }
    }
}
