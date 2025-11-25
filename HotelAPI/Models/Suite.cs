namespace HotelAPI.Models;

public class Suite
{
    public int Id { get; set; }
    public string TipoSuite { get; set; } = "Padrão";
    public int Capacidade { get; set; } = 2;
    public decimal ValorDiaria { get; set; } = 100.00m;

    public Suite() { }

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}
