namespace shared.Model;

public class Dato {
    public int DatoId { get; set; }
    public DateTime dato { get; set; }

    internal bool erIndenfor(DateTime startDen, DateTime slutDen)
    {
        throw new NotImplementedException();
    }
}