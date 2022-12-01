using System;
public class Coordenacao
{
    public string nomeCoordenador;
    public string idAluno;
    public string idProfessor;
    public string matriculaok;

public void MatriculaOk()
    {
        matriculaok = true;
        Console.WriteLine("matriculado");
    }
    public void MatriculaNegada()
    {
        matriculaok = false;
        Console.WriteLine("nao matriculado");
    }
    public void ConfirmarAluno()
    {
        if (matriculaok)
            Console.WriteLine("Aluno matriculado!");
        else
            Console.WriteLine("Não foi possível matricular o aluno, verificar pendências.");
    }
    public void GerarIdProfessor()
    {
    idProfessor = new Random().Next(0,100).ToString();
    }
    private string ObterIdProfessor()
    {
        return idProfessor;
    }
    
}