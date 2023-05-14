namespace shared.Model;

public class Dato {
    public int DatoId { get; set; }
    public DateTime dato { get; set; }

    internal bool erIndenfor(DateTime startDen, DateTime slutDen, DateTime givesDen)
    {
        if (startDen <= givesDen && givesDen <= slutDen)
        {
            return true;
        }
        return false;
    }
}