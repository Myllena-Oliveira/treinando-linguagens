using System;
public class Aluno
{
    public string nome;
    public string cpf;
    private string matricula;

    public void GerarMatricula()
    {
        matricula = new Random().Next(0,100).ToString();
    }
    public string ObterMatricula()
    {
        return matricula;
    }

}