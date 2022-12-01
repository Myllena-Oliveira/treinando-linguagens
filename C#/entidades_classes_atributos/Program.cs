using System;

namespace entidades_classes_atributos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Myllena Oliveira";
            a.GerarMatricula();
            Console.WriteLine("A matrícula de "+ a.nome +" é: " + a.ObterMatricula());

            Professor c = new Professor();
            c.nome = "Amanda Santos";
            c.AtualizarChamada();
            Console.WriteLine(" O aluno" + c.AtualizarChamada);

            Professor d = new Professor();
            d.nome = "Felipe Santos";
            d.AtualizarCaderneta();
            Console.WriteLine("Atualização de diário de classe: " + d.AtualizarCaderneta());

            CadastroRU e = new CadastroRU();
            e.cpf = "00000000000";
            e.GerarCodigo();
            Console.WriteLine("O código de "+ e.cpf +" é: " + e.ObterCodigo());

            CadastroRU f = new CadastroRU();
            f.cpf = "123456789121";
            f.LiberarCatraca();
            Console.WriteLine(f.LiberarCatraca());
           
           Coordenacao g = new Coordenacao();
           g.idAluno = a.GerarMatricula();
           g.ConfirmarAluno();
           Console.WriteLine(g.ConfirmarAluno());

            Faxineira h = new Faxineira();
            h.idFaxineira = h.GerarIdFaxineira();
            h.RealizarFaxina();
            Console.WriteLine(h.RealizarFaxina());

            Porteiro j = new Porteiro();
            j.nome = "Mateus Santos";
            j.ChecagemEntradaVeiculos();
            Console.WriteLine(j.ChecagemEntradaVeiculos());

            Porteiro k = new Porteiro();
            k.nome = "Micael Pereira";
            k.ChecagemSaídaVeiculos();
            Console.WriteLine(k.ChecagemSaídaVeiculos());

        }

    }
}