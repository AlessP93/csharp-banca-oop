
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
    public Utente utente { get; set; }
    public int Ammontare { get; set; }
    public int Rata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }

    public Prestito(int iD, Utente utente, int ammontare, int rata, DateOnly dataInizio, DateOnly dataFine)
    {
        ID = iD;
        this.utente = utente;
        Ammontare = ammontare;
        Rata = rata;
        DataInizio = dataInizio;
        DataFine = dataFine;
    }
    public Prestito()
    {

    }
}
