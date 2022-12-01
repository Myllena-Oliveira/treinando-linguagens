using System;
public class Porteiro
{
    public string nome;
    private string idPorteiro;
    public string horario;

    public void ChecagemEntradaVeiculos()
    {
        DateTime dataEntrada = DateTime.Now;
        Console.WriteLine("O veículo entrou no estabelecimento às" + dataEntrada);
    }
    public void ChecagemSaídaVeiculos()
    {
        DateTime dataSaída = DateTime.Now;
        Console.WriteLine("O veículo saiu do estabelecimento às" + dataSaída);
    }

}