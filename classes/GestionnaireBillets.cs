internal class GestionnaireBillets
{
    public delegate void ReservationDelegate(Billet billet);
    public delegate void AnnulationDelegate(int billetID);
}