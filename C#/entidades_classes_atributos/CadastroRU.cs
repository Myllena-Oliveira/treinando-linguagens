using System;
public class CadastroRU
{
    public string nome;
    public string cpf;
    private string codigo;
    protected bool liberado;

    public void GerarCodigo()
    {
        codigo = new Random().Next(0,100).ToString();
    }
    public string ObterCodigo()
    {
        return codigo;
    }

    public void Liberado()
    {
         liberado = true;
         Console.WriteLine("liberado");
    }
    public void NaoLiberado()
    {
         liberado = false;
         Console.WriteLine("nao liberado");
    }

    public void LiberarCatraca()
    {
        if (Liberado())
            Console.WriteLine("Bom apetite!");
        else
            Console.WriteLine("Tente Novamente");
    }
}