using Curso_C_;
using System.Text.Json;
using System.Globalization;


//var example = new VarUsageExample();
//example.DemonstrateVarUsage();

//var exemplo = new ExemploUsoDynamic();
//exemplo.DemonstrarUsoDynamic();

//var exemplo = new ExemploUsoLINQ();
//exemplo.DemonstrarUsoLINQ();

//var metodo = new Metodos();

// metodo.DemonstrarMetodos();

/*var explicacaoEnum = new ExplicacaoEnum();

//chamado o metodo pra demostrar o uso de enums
explicacaoEnum.DemonstrarEnum();

//exibindo a explicação detalhada sobre enums 

explicacaoEnum.ExplicacaoDetalhada();*/
/*var recursao = new Recursao();
recursao.DemonstrarRecursao();*/

/*var structs = new ExplicacaoStructs();
structs.DemonstrarDiferenca();*/

// Criando uma instância da classe NullableTypesDemo
/*var demo = new NullableTypesDemo();

// Definindo valores para os tipos nullable
demo.Numero = null; // Numero pode ser null
demo.EstaCompleto = true; // EstaCompleto pode ser null ou bool

// Exibindo os valores
demo.ExibirValores();

// Mostrando o uso do operador de coalescência nula
Console.WriteLine($"Valor de Numero ou padrão: {demo.ObterValorOuPadrao()}");

// Explicando os conceitos
demo.ExplicarConceitos();*/
/*
Colecoes colecoes = new Colecoes();

colecoes.ExplicarDictionary();
Console.WriteLine();

colecoes.ExplicarQueue();
Console.WriteLine();

colecoes.ExplicarStack();
Console.WriteLine();

colecoes.ExplicarSet();*/
/*
var miliante = new Pessoa1("Cantoara", 65);
miliante.Falar();


var soma = new Calculadora2024();
soma.A = 10;
soma.B = 20;

soma.Somar();
soma.Subtrair();

var chevrolet = new Carro {
    Modelo = "Onix LTZ",
    Ano = 2024,
    Preco = 34.999m};
chevrolet.MostrarInfo();


var senai = new Aluno("Bruno", 223695583);
string resultado = senai.ExibirNomeMat("Bruno", 223695583);
Console.WriteLine(resultado);

var senai1 = new Aluno("Isac", 36926988, "Masculino", 61991111111, "Candangolandia");
senai.ExibirTdInforma();
string resultado1 = senai1.ExibirTdInforma();
Console.WriteLine(resultado1);*/

//
/*using Curso_C_;
using System;
using System.Collections.Generic;

namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}

*/

/*// Instância de Cachorro [HERANÇA]
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();
*/

/*Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();*/

/*// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();*/

/*// Criando um objeto Carro, que inclui a criação de um Motor
Carros carro = new Carros("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/

/*// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/


/*
namespace SistemaGerenciamentoBilheteira
{
    class Program
    {
        static List<PessoaBilhete> pessoas = new List<PessoaBilhete>();
        static List<Show> shows = new List<Show>();
        static List<Ingresso> ingressos = new List<Ingresso>();

        static void Main(string[] args)
        {
            string caminhoPessoas = @"C:\Visual2022-Bruno\pessoas.json"; // Altere para o caminho absoluto do seu arquivo pessoas.json
            string caminhoShows = @"C:\Visual2022-Bruno\shows..json"; // Altere para o caminho absoluto do seu arquivo shows.json
            string caminhoIngressos = @"C:\Visual2022-Bruno\ingressos.json"; // Altere para o caminho absoluto do seu arquivo ingressos.json

            CarregarDados(caminhoPessoas, caminhoShows, caminhoIngressos);

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("========== BRASÍLIA BILHETERIA DIGITAL =======");
                Console.WriteLine("==============================================");
                Console.WriteLine($"Programador: Bruno R Queiroz");
                Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Clientes");
                Console.WriteLine("2. Gerenciar Shows");
                Console.WriteLine("3. Gerenciar Ingressos");
                Console.WriteLine("0. Sair\n");
                Console.WriteLine("==============================================\n");
                Console.Write("Digite uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuPessoas();
                        break;
                    case 2:
                        MenuShows();
                        break;
                    case 3:
                        MenuIngressos();
                        break;
                    case 0:
                        SalvarDados(caminhoPessoas, caminhoShows, caminhoIngressos); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuPessoas()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========== GERENCIAR CLIENTES ===============");
                           Console.WriteLine($"========== {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)} ===============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Buscar Clientes");
                Console.WriteLine("3. Atualizar Clientes");
                Console.WriteLine("4. Remover Clientes");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPessoa();
                        break;
                    case 2:
                        ListarPessoas();
                        break;
                    case 3:
                        AtualizarPessoa();
                        break;
                    case 4:
                        RemoverPessoa();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuShows()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("========== GERENCIAR SHOWS ==============");
                Console.WriteLine($"Programador: Bruno R Queiroz");
                Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");               
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Registrar Show");
                Console.WriteLine("2. Verificar Shows");
                Console.WriteLine("3. Atualizar Show");
                Console.WriteLine("4. Cancelar Show");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarShow();
                        break;
                    case 2:
                        ListarShows();
                        break;
                    case 3:
                        AtualizarShow();
                        break;
                    case 4:
                        RemoverShow();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuIngressos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("========== GERENCIAR INGRESSOS ==============");
                Console.WriteLine($"Programador: Bruno R Queiroz");
                Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Emitir Ingresso");
                Console.WriteLine("2. Ingressos Disponiveis");
                Console.WriteLine("3. Atualizar Ingresso");
                Console.WriteLine("4. Deletar Ingresso");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarIngresso();
                        break;
                    case 2:
                        ListarIngressos();
                        break;
                    case 3:
                        AtualizarIngresso();
                        break;
                    case 4:
                        RemoverIngresso();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarPessoa()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ADICIONAR NOVA PESSOA ============");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF da pessoa: ");
            string cpf = Console.ReadLine();

            if (pessoas.Exists(p => p.Cpf.Equals(cpf)))
            {
                Console.WriteLine("\nPessoa já existente.");
            }
            else
            {
                pessoas.Add(new PessoaBilhete(nome, cpf));
                Console.WriteLine("\nPessoa adicionada com sucesso!");
            }
        }

        static void ListarPessoas()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== LISTA DE PESSOAS ================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");

            if (pessoas.Count == 0)
            {
                Console.WriteLine("\nNenhuma pessoa cadastrada.");
            }
            else
            {
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"{pessoa.Nome} - {pessoa.Cpf}");
                    
                }
               
            }
        }

        static void AtualizarPessoa()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ATUALIZAR INFORMAÇÕES ============");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Digite o CPF da pessoa a ser atualizada:");
            ListarPessoas();

            string cpfAtual = Console.ReadLine();
            var pessoa = pessoas.Find(p => p.Cpf.Equals(cpfAtual));

            if (pessoa != null)
            {
                Console.Write("Digite o novo nome da pessoa: ");
                string novoNome = Console.ReadLine();

                pessoa.Nome = novoNome;
                Console.WriteLine("\nInformações da pessoa atualizadas com sucesso!");
            }
            else
            {
                Console.WriteLine("\n Por Favor Digite o CPF.");
                Console.WriteLine("\n Pessoa não encontrada.");
            }
        }

        static void RemoverPessoa()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== REMOVER PESSOA ===================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Digite o CPF da pessoa a ser removida:");
            ListarPessoas();

            string cpf = Console.ReadLine();
            var pessoa = pessoas.Find(p => p.Cpf.Equals(cpf));

            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine("\nPessoa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("\n Por Favor Digite o CPF para EXCLUIR.");
                Console.WriteLine("\nPessoa não encontrada.");
            }
        }

        static void AdicionarShow()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ADICIONAR NOVO SHOW ==============");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.Write("Digite o nome do show: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a data e hora do show (yyyy-MM-dd HH:mm): ");
            DateTime dataHora = DateTime.Parse(Console.ReadLine());

            shows.Add(new Show(nome, dataHora));
            Console.WriteLine("\nShow adicionado com sucesso!");
        }

        static void ListarShows()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== LISTA DE SHOWS ===================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");

            if (shows.Count == 0)
            {
                Console.WriteLine("\nNenhum show cadastrado.");
            }
            else
            {
                foreach (var show in shows)
                {
                    Console.WriteLine($"{show.Nome} - {show.DataHora}");
                }
            }
        }

        static void AtualizarShow()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ATUALIZAR SHOW ===================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Digite o nome do show a ser atualizado:");
            ListarShows();

            string nomeAtual = Console.ReadLine();
            var show = shows.Find(s => s.Nome.Equals(nomeAtual, StringComparison.OrdinalIgnoreCase));

            if (show != null)
            {
                Console.Write("Digite o novo nome do show: ");
                string novoNome = Console.ReadLine();
                Console.Write("Digite a nova data e hora do show (yyyy-MM-dd HH:mm): ");
                show.DataHora = DateTime.Parse(Console.ReadLine());

                show.Nome = novoNome;
                Console.WriteLine("\nInformações do show atualizadas com sucesso!");
            }
            else
            {
                Console.WriteLine("\n Por Favor Digite o Nome do Show.");
                Console.WriteLine("\nShow não encontrado.");
            }
        }

        static void RemoverShow()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== REMOVER SHOW =====================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Digite o nome do show a ser removido:");
            ListarShows();

            string nome = Console.ReadLine();
            var show = shows.Find(s => s.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (show != null)
            {
                shows.Remove(show);
                Console.WriteLine("\nShow removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nPor Favor Digite o Nome do Show para CANCELAR. ");
                Console.WriteLine("\nShow não encontrado.");
            }
        }

        static void AdicionarIngresso()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ADICIONAR NOVO INGRESSO ===========");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Selecione o show para adicionar o ingresso:");
            ListarShows();

            int showIndice = int.Parse(Console.ReadLine()) - 1;
            if (showIndice >= 0 && showIndice < shows.Count)
            {
                Console.Write("Digite o CPF da pessoa: ");
                string cpf = Console.ReadLine();
                var pessoa = pessoas.Find(p => p.Cpf.Equals(cpf));

                if (pessoa != null)
                {
                    ingressos.Add(new Ingresso(shows[showIndice], pessoa));
                    Console.WriteLine("\nIngresso adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nPessoa não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de show inválido.");
            }
        }

        static void ListarIngressos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== LISTA DE INGRESSES ===============");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");

            if (ingressos.Count == 0)
            {
                Console.WriteLine("\nNenhum ingresso registrado.");
            }
            else
            {
                foreach (var ingresso in ingressos)
                {
                    Console.WriteLine($"{ingresso.Show.Nome} - {ingresso.Show.DataHora}: {ingresso.Pessoa.Nome} ({ingresso.Pessoa.Cpf})");
                }
            }
        }

        static void AtualizarIngresso()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== ATUALIZAR INGRESSO ===============");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Selecione o ingresso para atualizar:");
            for (int i = 0; i < ingressos.Count; i++)
            {
                var ingresso = ingressos[i];
                Console.WriteLine($"{i + 1}. {ingresso.Show.Nome} - {ingresso.Show.DataHora}: {ingresso.Pessoa.Nome} ({ingresso.Pessoa.Cpf})");
            }

            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < ingressos.Count)
            {
                Console.Write("Digite o novo CPF da pessoa: ");
                string novoCpf = Console.ReadLine();
                var pessoa = pessoas.Find(p => p.Cpf.Equals(novoCpf));

                if (pessoa != null)
                {
                    ingressos[indice].Pessoa = pessoa;
                    Console.WriteLine("\nIngresso atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nPessoa não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de ingresso inválido.");
            }
        }

        static void RemoverIngresso()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========== REMOVER INGRESSO ================");
            Console.WriteLine($"Programador: Bruno R Queiroz");
            Console.WriteLine($"Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Selecione o ingresso a ser removido:");
            for (int i = 0; i < ingressos.Count; i++)
            {
                var ingresso = ingressos[i];
                Console.WriteLine($"{i + 1}. {ingresso.Show.Nome} - {ingresso.Show.DataHora}: {ingresso.Pessoa.Nome} ({ingresso.Pessoa.Cpf})");
            }

            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < ingressos.Count)
            {
                ingressos.RemoveAt(indice);
                Console.WriteLine("\nIngresso removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNúmero de ingresso inválido.");
            }
        }

        static void CarregarDados(string caminhoPessoas, string caminhoShows, string caminhoIngressos)
        {
            if (File.Exists(caminhoPessoas))
            {
                string jsonPessoas = File.ReadAllText(caminhoPessoas);
                pessoas = JsonSerializer.Deserialize<List<PessoaBilhete>>(jsonPessoas) ?? new List<PessoaBilhete>();
            }

            if (File.Exists(caminhoShows))
            {
                string jsonShows = File.ReadAllText(caminhoShows);
                shows = JsonSerializer.Deserialize<List<Show>>(jsonShows) ?? new List<Show>();
            }

            if (File.Exists(caminhoIngressos))
            {
                string jsonIngressos = File.ReadAllText(caminhoIngressos);
                ingressos = JsonSerializer.Deserialize<List<Ingresso>>(jsonIngressos) ?? new List<Ingresso>();
            }
        }

        static void SalvarDados(string caminhoPessoas, string caminhoShows, string caminhoIngressos)
        {
            string jsonPessoas = JsonSerializer.Serialize(pessoas);
            File.WriteAllText(caminhoPessoas, jsonPessoas);

            string jsonShows = JsonSerializer.Serialize(shows);
            File.WriteAllText(caminhoShows, jsonShows);

            string jsonIngressos = JsonSerializer.Serialize(ingressos);
            File.WriteAllText(caminhoIngressos, jsonIngressos);
        }
    }

    public class PessoaBilhete
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public PessoaBilhete(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Show
    {
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }

        public Show(string nome, DateTime dataHora)
        {
            Nome = nome;
            DataHora = dataHora;
        }
    }

    public class Ingresso
    {
        public Show Show { get; set; }
        public PessoaBilhete Pessoa { get; set; }

        public Ingresso(Show show, PessoaBilhete pessoa)
        {
            Show = show;
            Pessoa = pessoa;
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaGerenciamentoBilheteria
{
    class Program
    {
        static List<Evento> eventos = new List<Evento>();
        static List<Usuario> usuarios = new List<Usuario>();
        static List<Ingresso> ingressos = new List<Ingresso>();

        static string caminhoEventos = @"C:\Visual2022-Bruno\eventos.json";
        static string caminhoUsuarios = @"C:\Visual2022-Bruno\usuarios.json";
        static string caminhoIngressos = @"C:\Visual2022-Bruno\ingressos.json";

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                // Título do sistema
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto($"'           Programador: Bruno R Queiroz      '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto($"'   Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}       '");
                CentralizarTexto("' =========================================== '\n");

                // Opções do menu
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarComBorda("1-  Eventos");
                CentralizarComBorda("2- Clientes");
                CentralizarComBorda("3- Ingressos");
                Console.ForegroundColor = ConsoleColor.White;
               
                CentralizarTexto("' ========================================== '");

                // Centralizando a opção de saída com borda
                CentralizarComBorda("0. Sair");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nDigite uma opção: ");
                
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcao)
                {
                    case 1:
                        MenuEventos();
                        break;
                    case 2:
                        MenuUsuarios();
                        break;
                    case 3:
                        MenuIngressos();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuEventos()
        {
            int opcao;
            do
            {
                Console.Clear();
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto($"'           Programador: Bruno R Queiroz      '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto($"'   Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}       '");
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' =======  GERENCIAMENTO DE SHOWS   ========= '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '\n");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarComBorda("1. Cadastrar Evento");
                CentralizarComBorda("2. Consultar Eventos");
                CentralizarComBorda("3. Atualizar Eventos");
                Console.ForegroundColor = ConsoleColor.Red;
                CentralizarComBorda("4. Deletar Evento");
                Console.ForegroundColor = ConsoleColor.White;

                CentralizarTexto("' =========================================== '");

                // Centralizando a opção de voltar com borda
                CentralizarComBorda("0. Voltar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nEscolha uma opção: ");
                
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcao)
                {
                    case 1:
                        AdicionarEvento();
                        break;
                    case 2:
                        ListarEventos();
                        break;
                    case 3:
                        AtualizarEvento();
                        break;
                    case 4:
                        RemoverEvento();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                //Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuUsuarios()
        {
            int opcao;
            do
            {
                Console.Clear();
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto($"'           Programador: Bruno R Queiroz      '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto($"'   Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}       '");
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========  GERENCIAR CLIENTES  ============= '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '\n");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarComBorda("1. Cadastrar Cliente");
                CentralizarComBorda("2. Consultar Clientes");
                CentralizarComBorda("3. Atualizar Cliente");
                Console.ForegroundColor = ConsoleColor.Red;
                CentralizarComBorda("4. Deletar Cliente");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");

                // Centralizando a opção de voltar com borda
                CentralizarComBorda("0. Voltar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        AtualizarUsuario();
                        break;
                    case 4:
                        RemoverUsuario();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                //Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuIngressos()
        {
            int opcao;
            do
            {
                Console.Clear();
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto($"'           Programador: Bruno R Queiroz      '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto($"'   Seja Bem Vindo: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}       '");
                CentralizarTexto("' =========================================== '");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarTexto("' ========  GERENCIAR INGRESSOS  ============ '");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '\n");
                Console.ForegroundColor = ConsoleColor.Green;
                CentralizarComBorda("1. Vender Ingresso");
                CentralizarComBorda("2. Consultar Ingressos");
                CentralizarComBorda("3. Atualizar Ingresso");
                Console.ForegroundColor = ConsoleColor.Red;
                CentralizarComBorda("4. Remover Ingresso");
                Console.ForegroundColor = ConsoleColor.White;
                CentralizarTexto("' =========================================== '");

                // Centralizando a opção de voltar com borda

                CentralizarComBorda("0. Voltar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcao)
                {
                    case 1:
                        AdicionarIngresso();
                        break;
                    case 2:
                        ListarIngressos();
                        break;
                    case 3:
                        AtualizarIngresso();
                        break;
                    case 4:
                        RemoverIngresso();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                //Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        // Função para centralizar texto
        static void CentralizarTexto(string texto)
        {
            int larguraConsole = 40; // Tamanho fixo da linha
            if (texto.Length < larguraConsole)
            {
                int espacosEsquerda = (larguraConsole - texto.Length) / 2;
                string paddingEsquerda = new string(' ', espacosEsquerda);
                Console.WriteLine(paddingEsquerda + texto);
            }
            else
            {
                Console.WriteLine(texto);
            }
        }

        // Função para centralizar texto com bordas
        static void CentralizarComBorda(string texto)
        {
            string border = new string('.', texto.Length + 4); // Cria uma borda de acordo com o tamanho do texto
            CentralizarTexto(border);                          // Centraliza a borda superior
            CentralizarTexto($" {texto}  ");                  // Centraliza o texto com borda
            CentralizarTexto($"{border}\n");                          // Centraliza a borda inferior
        }

        // Métodos para manipulação de usuários
        static void AdicionarUsuario()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =====     ADICIONAR NOVO CLIENTE   ======== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            string nome;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Nome do Cliente ? : ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome) || !IsNomeValido(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido. O nome não pode estar vazio e não deve conter números. Por favor, insira um nome válido.");
                }
            } while (string.IsNullOrWhiteSpace(nome) || !IsNomeValido(nome));

            string cpf;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual CPF do Cliente ? : ");
                cpf = Console.ReadLine();
                if (!IsCpfValido(cpf))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                }
            } while (!IsCpfValido(cpf));

            string telefone;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Telefone do Cliente ? : ");
                telefone = Console.ReadLine();
                if (!IsTelefoneValido(telefone))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Telefone inválido. O telefone não pode conter letras e deve ter 10 ou 11 dígitos. Por favor, insira um telefone válido.");
                }
            } while (!IsTelefoneValido(telefone));

            Console.ForegroundColor = ConsoleColor.White;

            int id = usuarios.Count > 0 ? usuarios[^1].Id + 1 : 1;
            Usuario usuario = new Usuario(id, nome, cpf, telefone);
            usuarios.Add(usuario);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCliente CADASTRADO COM SUCESSO !");
            SalvarDados();
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Função para validar o CPF (apenas uma validação básica)
        static bool IsCpfValido(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // Remove caracteres não numéricos
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            // Verifica se o CPF possui 11 dígitos e se contém apenas números
            return cpf.Length == 11 && cpf.All(char.IsDigit);
        }

        // Função para validar o telefone (não pode conter letras e deve ter 10 ou 11 dígitos)
        static bool IsTelefoneValido(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                return false;

            // Remove caracteres não numéricos
            telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            // Verifica se o telefone possui 10 ou 11 dígitos e se contém apenas números
            return (telefone.Length == 10 || telefone.Length == 11) && telefone.All(char.IsDigit);
        }

        // Função para validar o nome (não pode conter números)
        static bool IsNomeValido(string nome)
        {
            // Verifica se o nome contém números
            return !nome.Any(char.IsDigit);
        }
         
        static void ListarUsuarios()
        {
            Console.Clear();
            //CentralizarTexto("' =========================================== '");
          //  Console.ForegroundColor = ConsoleColor.Green;
          //  CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
        //    Console.ForegroundColor = ConsoleColor.White;
         //   CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' ======       CLIENTES CADASTRADOS   ======= '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");
            

            if (usuarios.Count == 0)
            {
                Console.WriteLine("\nNenhum usuário cadastrado.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    ExibirUsuarioComoPlanilha(usuario);
                   // Console.ForegroundColor = ConsoleColor.Green;
                    //CentralizarTexto($"ID: {usuario.Id}");
                    //Console.ForegroundColor = ConsoleColor.White;
                   // CentralizarTexto($"Cliente: {usuario.Nome} ");
                   // CentralizarTexto($"CPF: {usuario.Cpf}");
                   // CentralizarTexto($"Telefone : {usuario.Telefone}\n");
                }
            }
        }

        static void AtualizarUsuario()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' ========   ATUALIZAR CLIENTE   =========== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' ========================================== '\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o 'ID' ou 'CPF' do Cliente Para Atualizar: ");
            string input = Console.ReadLine();
            Usuario usuario = null;
            Console.ForegroundColor = ConsoleColor.White;

            // Buscar pelo ID ou CPF
            if (int.TryParse(input, out int id))
            {
                usuario = usuarios.Find(u => u.Id == id);
            }
            else
            {
                usuario = usuarios.Find(u => u.Cpf.Replace(".", "").Replace("-", "") == input.Replace(".", "").Replace("-", ""));
            }

            if (usuario != null)
            {
                string nome;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite o novo nome do Cliente: ");
                    nome = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nome inválido. O nome não pode estar vazio e não deve conter números.");
                    }
                } while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit));
                usuario.Nome = nome;

                // Atualizar CPF se necessário
                // string cpf;
                // do
                // {
                //     Console.Write("Digite o novo CPF do Cliente: ");
                //     cpf = Console.ReadLine();
                //     if (!IsCpfValido(cpf))
                //     {
                //         Console.ForegroundColor = ConsoleColor.Red;
                //         Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                //     }
                // } while (!IsCpfValido(cpf));
                // usuario.Cpf = cpf;

                string telefone;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite o novo Telefone do Cliente: ");
                    telefone = Console.ReadLine();
                    if (!IsTelefoneValido(telefone))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Telefone inválido. Por favor, insira um telefone válido.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (!IsTelefoneValido(telefone));
                usuario.Telefone = telefone;

                SalvarDados();
                ExibirUsuarioComoPlanilha(usuario);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCliente ATUALIZADO COM SUCESSO !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado.");
            }
        }

        static void ExibirUsuarioComoPlanilha(Usuario usuario)
        {
            // Definindo largura das colunas
            int larguraId = 5;
            int larguraNome = 25;
            int larguraCpf = 15;
            int larguraTelefone = 15;

            // Cabeçalhos
            string header = $"{"ID".PadRight(larguraId)} | {"Nome".PadRight(larguraNome)} | {"CPF".PadRight(larguraCpf)} | {"Telefone".PadRight(larguraTelefone)}";
            string separador = new string('-', larguraId + larguraNome + larguraCpf + larguraTelefone + 10);

            Console.WriteLine(separador);
            Console.WriteLine(header);
            Console.WriteLine(separador);

            // Dados do usuário
            string linha = $"{usuario.Id.ToString().PadRight(larguraId)} | {usuario.Nome.PadRight(larguraNome)} | {usuario.Cpf.PadRight(larguraCpf)} | {usuario.Telefone.PadRight(larguraTelefone)}";
            Console.WriteLine(linha);

            Console.WriteLine(separador);

        }
        static void RemoverUsuario()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =========     DELETAR CLIENTE    ========== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o ID ou CPF do cliente para Deletar: ");
            string input = Console.ReadLine();
            Usuario usuario = null;
            Console.ForegroundColor = ConsoleColor.White;

            // Buscar pelo ID ou CPF
            if (int.TryParse(input, out int id))
            {
                usuario = usuarios.Find(u => u.Id == id);
            }
            else
            {
                string cpf = input.Replace(".", "").Replace("-", "");
                if (!IsCpfValido(cpf))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                    return;
                }

                usuario = usuarios.Find(u => u.Cpf.Replace(".", "").Replace("-", "") == cpf);
            }

            if (usuario != null)
            {
                // Exibir informações do usuário a ser removido
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações do Cliente a Ser Removido:");
                ExibirUsuarioComoPlanilha(usuario);

                // Confirmar exclusão
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nTem certeza que deseja remover este cliente? (S/N): ");
                string confirmacao = Console.ReadLine()?.Trim().ToUpper();

                if (confirmacao == "S")
                {
                    usuarios.Remove(usuario);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCliente DELETADO COM SUCESSO!");
                    SalvarDados();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOperação de exclusão cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUsuário não encontrado.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
               



        // Métodos para manipulação de eventos
        static void AdicionarEvento()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =====     AGENDAR NOVO EVENTO   ========= '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            // Validação para garantir que o nome não esteja vazio
            string nome;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual Nome do Evento? : ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome não pode estar vazio. Por favor, insira um nome válido.");
                }
            } while (string.IsNullOrWhiteSpace(nome));

            // Validação da data do evento
            DateTime data;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual a data do evento (dd/MM/yyyy)? : ");
                string dataInput = Console.ReadLine();
                if (DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                {
                    break; // Data válida
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Data inválida. Por favor, insira a data no formato dd/MM/yyyy.");
                }
            }

            // Validação do local do evento
            string local;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual local do evento? : ");
                local = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(local))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Local não pode estar vazio. Por favor, insira um local válido.");
                }
            } while (string.IsNullOrWhiteSpace(local));

            // Validação da capacidade do evento
            int capacidade;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite a capacidade máxima do evento: ");
                string capacidadeInput = Console.ReadLine();
                if (int.TryParse(capacidadeInput, out capacidade) && capacidade > 0)
                {
                    break; // Capacidade válida
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Capacidade inválida. Por favor, insira um número inteiro positivo.");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            int id = eventos.Count > 0 ? eventos[^1].Id + 1 : 1;
            Evento evento = new Evento(id, nome, data, local, capacidade);
            eventos.Add(evento);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEvento AGENDADO COM SUCESSO!");
            SalvarDados();
            Console.ForegroundColor = ConsoleColor.White;
        }





        static void ListarEventos()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine("' ========       INGRESSOS VENDIDOS  ======== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '");

            if (eventos.Count == 0)
            {
                Console.WriteLine("\nNenhum evento cadastrado.");
            }
            else
            {
                // Exibir cabeçalhos da "planilha"
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("{0,-5} | {1,-20} | {2,-12} | {3,-20} | {4,-10}", "ID", "Nome", "Data", "Local", "Capacidade");
                Console.WriteLine("-----------------------------------------------------------------------------------");

                // Exibir dados dos eventos
                foreach (var evento in eventos)
                {
                    Console.WriteLine("{0,-5} | {1,-20} | {2,-12} | {3,-20} | {4,-10}",
                        evento.Id,
                        evento.Nome,
                        evento.Data.ToString("dd/MM/yyyy"),
                        evento.Local,
                        evento.Capacidade);
                }
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }

        }

        static void AtualizarEvento()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' ============   EDITAR EVENTO   ============ '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Qual 'ID' do evento a ser atualizado ?: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID inválido. Por favor, insira um número inteiro.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Evento evento = eventos.Find(e => e.Id == id);
            Console.ForegroundColor = ConsoleColor.White;

            if (evento != null)
            {
                // Exibir informações antes da atualização
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações Atuais do Evento:");
                ExibirEventoComoPlanilha(evento);

                // Validação e atualização dos dados
                string nome;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Qual o novo nome do evento ?: ");
                    nome = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nome não pode estar vazio. Por favor, insira um nome válido.");
                    }
                } while (string.IsNullOrWhiteSpace(nome));
                evento.Nome = nome;

                DateTime data;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite a nova data do evento (dd/MM/yyyy): ");
                    string dataInput = Console.ReadLine();
                    if (DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                    {
                        break; // Data válida
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Data inválida. Por favor, insira a data no formato dd/MM/yyyy.");
                    }
                }
                evento.Data = data;

                string local;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite o novo local do evento: ");
                    local = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(local))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Local não pode estar vazio. Por favor, insira um local válido.");
                    }
                } while (string.IsNullOrWhiteSpace(local));
                evento.Local = local;

                int capacidade;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite a nova capacidade do evento: ");
                    string capacidadeInput = Console.ReadLine();
                    if (int.TryParse(capacidadeInput, out capacidade) && capacidade > 0)
                    {
                        break; // Capacidade válida
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Capacidade inválida. Por favor, insira um número inteiro positivo.");
                    }
                }
                evento.Capacidade = capacidade;

                // Exibir informações após a atualização
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEvento ATUALIZADO COM SUCESSO!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações Atualizadas do Evento:");
                ExibirEventoComoPlanilha(evento);

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEvento não encontrado.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ExibirEventoComoPlanilha(Evento evento)
        {
            Console.WriteLine("{0,-5} | {1,-30} | {2,-15:dd/MM/yyyy} | {3,-20} | {4,-10}",
                evento.Id, evento.Nome, evento.Data, evento.Local, evento.Capacidade);
        }



        static void RemoverEvento()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' ==========     DELETAR EVENTO    ========== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Qual o 'ID' do evento a ser removido ?: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID inválido. Por favor, insira um número inteiro.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Evento evento = eventos.Find(e => e.Id == id);
            Console.ForegroundColor = ConsoleColor.White;

            if (evento != null)
            {
                // Exibir informações do evento a ser removido
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações do Evento a Ser Removido:");
                ExibirEventoComoPlanilha(evento);

                // Confirmar exclusão
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nTem certeza que deseja remover este evento? (S/N): ");
                string confirmacao = Console.ReadLine()?.Trim().ToUpper();

                if (confirmacao == "S")
                {
                    eventos.Remove(evento);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEvento DELETADO COM SUCESSO !");
                    SalvarDados();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOperação de exclusão cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEvento não encontrado.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }




        // Métodos para manipulação de ingressos
        static void AdicionarIngresso()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =========     VENDA DE INGRESSOS   ======== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '");

            // Validação do ID do Evento
            Evento evento = null;
            int eventoId;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual o ID do Evento ? : ");
                string eventoIdInput = Console.ReadLine();

                if (!int.TryParse(eventoIdInput, out eventoId) || (evento = eventos.Find(e => e.Id == eventoId)) == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID do Evento inválido ou Evento não encontrado. Por favor, insira um número válido.");
                }
            } while (evento == null);

            if (evento.Capacidade <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO evento está lotado.");
                return;
            }

            // Validação do ID ou CPF do Cliente
            Usuario usuario = null;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Qual o 'ID' ou CPF do Cliente ? : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int id))
                {
                    // Busca por ID
                    usuario = usuarios.Find(u => u.Id == id);
                }
                else
                {
                    // Remove formatação e verifica o CPF
                    string cpf = input.Replace(".", "").Replace("-", "");
                    if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O CPF deve conter exatamente 11 dígitos numéricos.");
                        usuario = null;
                    }
                    else if (!IsCpfValido(cpf))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                        usuario = null;
                    }
                    else
                    {
                        usuario = usuarios.Find(u => u.Cpf.Replace(".", "").Replace("-", "") == cpf);
                    }
                }

                if (usuario == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUsuário não encontrado ou CPF inválido. Por favor, insira um ID ou CPF válido.");
                }
            } while (usuario == null);

            // Confirmação da compra
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nVocê está prestes a comprar um ingresso para o evento '{evento.Nome}' com ID {eventoId} para o usuário '{usuario.Nome}'.");
            Console.Write("Deseja confirmar a compra? (S/N): ");
            string confirmacao = Console.ReadLine().ToUpper();

            if (confirmacao != "S")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Compra cancelada.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            // Gera o próximo ID para o ingresso
            int ingressoId = ingressos.Count > 0 ? ingressos[^1].Id + 1 : 1;
            // Cria o ingresso com o ID do usuário encontrado
            Ingresso ingresso = new Ingresso(ingressoId, usuario.Id, eventoId, DateTime.Now);
            ingressos.Add(ingresso);

            evento.Capacidade--; // Reduz a capacidade do evento ao vender um ingresso
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCompra de INGRESSO COM SUCESSO!");

            // Exibe as informações do evento e do usuário em formato de planilha
            Console.ForegroundColor = ConsoleColor.White;

            // Detalhes do Evento
            Console.WriteLine("\nDetalhes do Evento:");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine("| ID                | Nome                    |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| {evento.Id,-17} | {evento.Nome,-23} |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| Data              | Local                   |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| {evento.Data:dd/MM/yyyy,-17} | {evento.Local,-23} |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| Capacidade Restante: {evento.Capacidade,-16} |");
            Console.WriteLine("+-------------------+-------------------------+");

            // Detalhes do Usuário
            Console.WriteLine("\nDetalhes do Usuário:");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine("| ID                | Nome                    |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| {usuario.Id,-17} | {usuario.Nome,-23} |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| CPF               | Telefone                |");
            Console.WriteLine("+-------------------+-------------------------+");
            Console.WriteLine($"| {usuario.Cpf,-17} | {usuario.Telefone,-23} |");
            Console.WriteLine("+-------------------+-------------------------+");

            SalvarDados();
            Console.ForegroundColor = ConsoleColor.White;
        }







        static void ListarIngressos()
        { //ESTOU AQUI 
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =========      VENDA DE INGRESSOS   ======= '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '");

            // Exibe os cabeçalhos das colunas
            Console.WriteLine("{0,-5} | {1,-30} | {2,-30} | {3,-15}",
                "ID", "Evento", "Comprado por", "Data da Compra");
            Console.WriteLine(new string('-', 80)); // Linha separadora

            if (ingressos.Count == 0)
            {
                Console.WriteLine("\nNenhum ingresso cadastrado.");
            }
            else
            {
                foreach (var ingresso in ingressos)
                {
                    // Busca o evento e o usuário relacionados ao ingresso
                    var evento = eventos.Find(e => e.Id == ingresso.EventoId);
                    var usuario = usuarios.Find(u => u.Id == ingresso.UsuarioId);

                    if (evento == null || usuario == null)
                    {
                        // Se evento ou usuário não forem encontrados, exibe uma mensagem de erro
                        Console.WriteLine($"Erro: Dados não encontrados para o ingresso ID {ingresso.Id}.");
                        continue; // Pula para o próximo ingresso
                    }

                    // Exibe os dados do ingresso no formato de tabela
                    Console.WriteLine("{0,-5} | {1,-30} | {2,-30} | {3,-15:dd/MM/yyyy}",
                        ingresso.Id, evento.Nome, usuario.Nome, ingresso.DataCompra);
                }
            }
        }



        static void AtualizarIngresso()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' ========   ATUALIZAR INGRESSO   =========== '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");

            // Buscar ingresso
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o ID do ingresso para atualização: ");
            int id = int.Parse(Console.ReadLine());
            Ingresso ingresso = ingressos.Find(i => i.Id == id);

            if (ingresso != null)
            {
                // Exibir informações atuais do ingresso
                Evento eventoAtual = eventos.Find(e => e.Id == ingresso.EventoId);
                Usuario usuarioAtual = usuarios.Find(u => u.Id == ingresso.UsuarioId);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações atuais do ingresso:");
                ExibirDadosEmPlanilha(new string[] { "ID", "Evento", "Usuário", "Data de Compra" },
                                          new string[] { ingresso.Id.ToString(), eventoAtual?.Nome ?? "Desconhecido", usuarioAtual?.Nome ?? "Desconhecido", ingresso.DataCompra.ToString("dd/MM/yyyy HH:mm:ss") });
                Console.ForegroundColor = ConsoleColor.White;

                // Atualizar evento
                Evento evento = null;
                int eventoId;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite o novo ID do evento: ");
                    string eventoIdInput = Console.ReadLine();
                    if (!int.TryParse(eventoIdInput, out eventoId) || (evento = eventos.Find(e => e.Id == eventoId)) == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ID do Evento inválido ou Evento não encontrado. Por favor, insira um número válido.");
                    }
                } while (evento == null);

                if (evento.Capacidade <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO evento está lotado.");
                    return;
                }

                // Atualizar usuário
                Usuario usuario = null;
                string input;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite o novo 'ID' ou 'CPF' do usuário: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int usuarioId))
                    {
                        usuario = usuarios.Find(u => u.Id == usuarioId);
                    }
                    else
                    {
                        string cpf = input.Replace(".", "").Replace("-", "");
                        if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O CPF deve conter exatamente 11 dígitos numéricos.");
                            usuario = null;
                        }
                        else if (!IsCpfValido(cpf))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                            usuario = null;
                        }
                        else
                        {
                            usuario = usuarios.Find(u => u.Cpf.Replace(".", "").Replace("-", "") == cpf);
                        }
                    }

                    if (usuario == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nUsuário não encontrado ou CPF inválido. Por favor, insira um ID ou CPF válido.");
                    }
                } while (usuario == null);

                // Exibir informações novas e confirmar
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVocê está prestes a atualizar o ingresso para o evento '{0}' com ID {1} para o usuário '{2}'.",
                                  evento.Nome, eventoId, usuario.Nome);
                Console.Write("Deseja confirmar a atualização? (S/N): ");
                string confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atualização cancelada.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

                // Atualizar as informações do ingresso
                ingresso.EventoId = eventoId;
                ingresso.UsuarioId = usuario.Id;
                ingresso.DataCompra = DateTime.Now;

                // Buscar informações atualizadas
                Evento novoEvento = eventos.Find(e => e.Id == ingresso.EventoId);
                Usuario novoUsuario = usuarios.Find(u => u.Id == ingresso.UsuarioId);

                // Exibir informações atualizadas do ingresso
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações atualizadas do ingresso:");
                ExibirDadosEmPlanilha(new string[] { "ID", "Evento", "Usuário", "Data de Compra" },
                                          new string[] { ingresso.Id.ToString(), novoEvento?.Nome ?? "Desconhecido", novoUsuario?.Nome ?? "Desconhecido", ingresso.DataCompra.ToString("dd/MM/yyyy HH:mm:ss") });
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIngresso atualizado com sucesso!");
                SalvarDados();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIngresso não encontrado.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        // Função para exibir dados em formato de planilha
        static void ExibirDadosEmPlanilha(string[] cabecalhos, string[] valores)
        {
            // Exibir cabeçalhos
            Console.WriteLine("+----------------+-------------------------+");
            Console.WriteLine("| {0,-14} | {1,-23} |", cabecalhos[0], cabecalhos[1]);
            Console.WriteLine("+----------------+-------------------------+");

            // Exibir valores
            Console.WriteLine("| {0,-14} | {1,-23} |", valores[0], valores[1]);
            Console.WriteLine("+----------------+-------------------------+");
        }







        //PAREI AQUI NA VALIDAÇÃO !
        static void RemoverIngresso()
        {
            Console.Clear();
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            CentralizarTexto("' ========= BRASÍLIA BILHETERIA DIGITAL ===== '");
            Console.ForegroundColor = ConsoleColor.White;
            CentralizarTexto("' =========================================== '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("' =========     REMOVER INGRESSO    ========= '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' =========================================== '\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Solicitar o ID do ingresso
            Console.Write("Digite o ID do ingresso a ser removido: ");
            int id = int.Parse(Console.ReadLine());
            Ingresso ingresso = ingressos.Find(i => i.Id == id);

            if (ingresso != null)
            {
                Evento evento = eventos.Find(e => e.Id == ingresso.EventoId);
                Usuario usuario = usuarios.Find(u => u.Id == ingresso.UsuarioId);

                // Exibir as informações do ingresso antes da remoção
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInformações do ingresso:");
                ExibirDadosEmPlanilha(new string[] { "ID", "Evento", "Usuário", "Data de Compra" },
                                      new string[] { ingresso.Id.ToString(), evento?.Nome ?? "Desconhecido", usuario?.Nome ?? "Desconhecido", ingresso.DataCompra.ToString("dd/MM/yyyy HH:mm:ss") });
                Console.ForegroundColor = ConsoleColor.White;

                // Solicitar confirmação
                Console.Write("\nTem certeza que deseja remover este ingresso? (S/N): ");
                string confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "S")
                {
                    // Repor a capacidade do evento ao remover o ingresso
                    evento.Capacidade++;

                    // Remover o ingresso
                    ingressos.Remove(ingresso);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nIngresso REMOVIDO COM SUCESSO!");
                    SalvarDados();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nRemoção cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIngresso não encontrado.");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }       
        




        // Métodos de salvamento e carregamento de dados
        static void SalvarDados()
        {
            File.WriteAllText(caminhoEventos, JsonSerializer.Serialize(eventos));
            File.WriteAllText(caminhoUsuarios, JsonSerializer.Serialize(usuarios));
            File.WriteAllText(caminhoIngressos, JsonSerializer.Serialize(ingressos));
        }

        static void CarregarDados()
        {
            if (File.Exists(caminhoEventos))
                eventos = JsonSerializer.Deserialize<List<Evento>>(File.ReadAllText(caminhoEventos));

            if (File.Exists(caminhoUsuarios))
                usuarios = JsonSerializer.Deserialize<List<Usuario>>(File.ReadAllText(caminhoUsuarios));

            if (File.Exists(caminhoIngressos))
                ingressos = JsonSerializer.Deserialize<List<Ingresso>>(File.ReadAllText(caminhoIngressos));
        }
    }

    // Definições de classes

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Usuario(int id, string nome, string cpf, string telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }

    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int Capacidade { get; set; }

        public Evento(int id, string nome, DateTime data, string local, int capacidade)
        {
            Id = id;
            Nome = nome;
            Data = data;
            Local = local;
            Capacidade = capacidade;
        }
    }

    public class Ingresso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EventoId { get; set; }
        public DateTime DataCompra { get; set; }

        public Ingresso(int id, int usuarioId, int eventoId, DateTime dataCompra)
        {
            Id = id;
            UsuarioId = usuarioId;
            EventoId = eventoId;
            DataCompra = dataCompra;
        }
    }
}
