using System;
using System.Text.RegularExpressions;
using TrabalhoFinal.Models;
using TrabalhoFinal.Processos;
using TrabalhoFinal.Repositorios;
using System.IO;
using System.Text;
using CsvHelper;


/*
PREMISSAS DO PROJETO FINAL
1 - sistema de login para separar usuários/contas.
2 - cadastro de usuários/contas.
3 - com cadastro de categoria para os seus gastos.
4 - cadastros dos seus créditos/débitos, segmentados por categoria e data.
5 - relatório de receitas e despesas.
*/

namespace TrabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {









            // PASSO A PASSO
            // Reconhecer as classes de conceitos do negócio (pessoa, categoria)
            // Melhoramos essas classes trocando string de email por uma classe Email... CPF
            // Processos: quais são, e colocar classes para representar cada processo (segmentado por Model)
            // Repositórios: interação com algum mecanismo de persistência (lista em memória)
            // Program.cs onde vai ligar tudo (papagaio de pirata)

            // SETUP
            // Criar as instâncias das classes de process
            // Criar as instâncias das classes de repositorio
            var repositorioPessoas = new RepositorioPessoas();
            var processosPessoas = new ProcessosPessoas(repositorioPessoas);
            var repositorioCategorias = new RepositorioCategorias();
            var ProcessosCategorias = new ProcessosCategorias(repositorioCategorias);


            // INTERAÇÃO COM USUÁRIO
            //var login = new Login();
            //login.Run();
            
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            if (nome == "")
                throw new System.Exception("Nome não pode estar em branco");



            Console.WriteLine("Digite seu Email: ");
            string email = Console.ReadLine();
            var mail = new Email(email);

            Console.WriteLine("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            var cpf1 = new Cpf(cpf);

            Console.WriteLine("Digite seu senha: ");
            string senha = Console.ReadLine();

            Pessoa pessoa = processosPessoas.Cadastrar(nome, mail, cpf1, senha);



            var idPessoa = repositorioPessoas.Cadastrar(pessoa);
            var acheiPessoa = repositorioPessoas.BuscarPorId(2);

            Console.WriteLine("Id: {0}", idPessoa);

            Console.WriteLine("Pessoa: {0}", acheiPessoa.Nome);
            Console.WriteLine("Cadastro Realizado com Sucesso");


            Console.WriteLine("\n");
            Console.WriteLine("TELA DE LOGIN");
            Console.WriteLine("====================" + "\n");





            Console.WriteLine("Digite seu Email: ");
            string emailLogin = Console.ReadLine();
            var mailLogin = new Email(emailLogin);

            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();


            var login1 = processosPessoas.Login(mailLogin, senhaLogin);
            if (login1.Sucesso)
            {
                Console.WriteLine("Pessoa Logada com sucesso: {0}", login1.PessoaCasoSucesso.Nome);

                System.Console.WriteLine("\n" + "TELA DA CATEGORIAS" + "\n" + "==========" + "\n" + "Favor Cadastrar um Lançamento: ");

                Console.WriteLine("Digite o nome do lançamento: ");
                string nomeLancamento = Console.ReadLine();
                if (nomeLancamento == "")
                    throw new System.Exception("Nome não pode estar em branco");

                System.Console.WriteLine("o formato da data de lançamento deve ser como neste exemplo: Jan 1, 2009");
                System.Console.WriteLine("informe a data: ");
                
                string dateInput = Console.ReadLine();
                var parsedDate = DateTime.Parse(dateInput);

                System.Console.WriteLine("informe o tipo de lançamento"+"\n"+"(Crédito ou Débito): ");
                string tipo = Console.ReadLine();

                


                Categoria lancamento = ProcessosCategorias.CadastrarCategoria(1, nomeLancamento, parsedDate, tipo);

                var idCategoria = repositorioCategorias.CadastrarCategoria(lancamento);



                Console.WriteLine("Cadastro Realizado com Sucesso: " + lancamento.NomeCategoria + " "+ parsedDate + " "+ tipo);

                /*
                System.Console.WriteLine("Deseja cadastrar mais um lançamento(1 para sim ou 2 para não): ");
                string escolha = Console.ReadLine();
                var escolhaInt = int.Parse(escolha);

                System.Console.WriteLine(escolhaInt);
                */

                




            }
            else
            {
                Console.WriteLine("Erro ao logar no aplicativo");

            }

            //    var pessoa =  {
            //         "nome": "Gabriel",
            //         "id": 2,
            //         "email": "gabriel.carecoso@gmail.com",
            //         "senha": 123
            //     }



            // Verificar os inputs
            // Fazer parse
            // Direcionar para as classes de processo necessárias/apropriadas
            // Mostrar o resultado


            //new RepositorioPessoas()

            //criar método para criar arquivo de texto(csv) ler, gravar,excluir




        }
    }
}





