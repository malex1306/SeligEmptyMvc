namespace MitarbeiterVerwaltung1.Models;

public class Mitarbeiter
{
    public int Id { get; set; }
    public string? Vorname { get; set; }
    public string? Nachname { get; set; }
    public DateOnly Geburtsdatum { get; set; }
}