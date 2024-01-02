public class Billet
{
    public byte ID { get; set; }
    public Spectacle Spectacle { get; set; }
    public Utilisateur Utilisateur { get; set; }
    public bool StatutReservation { get; set; }
}