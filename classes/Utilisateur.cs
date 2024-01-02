public class Utilisateur
{
    public byte ID { get; set; }
    public string Nom { get; set; }
    public List<Billet> HistoriqueReservations { get; set; } = new List<Billet>();
}