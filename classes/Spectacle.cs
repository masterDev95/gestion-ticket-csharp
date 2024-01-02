public class Spectacle
{
    public byte ID { get; set; }
    public string Titre { get; set; }
    public DateTime Date { get; set; }
    public string Lieu { get; set; }
    public short NombrePlacesDisponibles { get; set; }
    public List<Billet> Billets { get; set; } = new List<Billet>();

    public bool Equals(Spectacle spectacle)
    {
        return spectacle.ID == ID;
    }
}