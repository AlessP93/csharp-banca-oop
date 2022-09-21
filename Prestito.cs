
//3 I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
public class Prestito
{
    public int ID { get; set; }

    Utente utente;
    public int Ammontare { get; set; }
    public int Rata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }
}
