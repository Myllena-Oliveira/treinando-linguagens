using System;
public class Professor
{
        
    public string nome;
    public string cpf;
    public string aluno;
    public string caderneta;
    protected bool presente;


    public void Presente()
    {
         presente = true;
         Console.WriteLine("presente");
    }
    public void Faltou()
    {
         presente = false;
         Console.WriteLine("Faltou");
    }
    public void AtualizarChamada()
    {
         if (Presente())
            Console.WriteLine("O aluno está presente");
        else
            Console.WriteLine("O aluno faltou");
    }
    public void AtualizarCaderneta()
    {
        Console.WriteLine("Atualização de diário de classe: ");
    }
}