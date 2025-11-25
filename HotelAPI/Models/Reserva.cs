namespace HotelAPI.Models;

public class Reserva
{
    public List<Pessoa>? Hospedes { get; set; }
    public Suite? Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        Hospedes = hospedes;
        Suite = suite;
        DiasReservados = diasReservados;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
        {
            throw new Exception("Suite não cadastrada.");
        }

        if (hospedes.Count <= Suite?.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception($"A reserva deve ter no máximo {Suite?.Capacidade} hospedes.");
        }
    }

    public decimal? CalcularValorDiaria()
    {
        return Suite?.ValorDiaria * DiasReservados;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes?.Count ?? 0;
    }
}
