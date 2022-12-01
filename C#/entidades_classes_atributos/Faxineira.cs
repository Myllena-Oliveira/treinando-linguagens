using System;
public class Faxineira
{
    public string nome;
    public string idFaxineira;
    public string dataFaxina;
    public string faxinaok;

    public void GerarIdFaxineira()
    {
    idFaxineira = new Random().Next(0,100).ToString();
    }
    public string ObterIdFaxineira()
    {
        return idFaxineira;
    }

    public void FaxinaOk()
    {
        faxinaok = true;
        Console.WriteLine("faxina realizada");
    }
    public void FaxinaFalse()
    {
        faxinaok = false;
        Console.WriteLine("faxina não foi realizada");
    }
    public void RealizarFaxina()
    {
        DateTime dataFaxina = DateTime.Now;
        if (FaxinaOk())
            Console.WriteLine("A faxina foi realizada em" + dataFaxina);
        else
            Console.WriteLine("A faxina não foi realizada em" + dataFaxina);
    }
    
}