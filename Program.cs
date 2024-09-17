using Curso_C_;
using System;

using System.Text.Json;

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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Globalization;

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
