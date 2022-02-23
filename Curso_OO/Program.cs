using System;
using System.Globalization;

namespace Curso_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXEMPLO S/ Orientação à OBJETO;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite X: ");
            double x1 = double.Parse(Console.ReadLine(),CI);
            double x2 = double.Parse(Console.ReadLine(), CI);
            double x3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            double y1 = double.Parse(Console.ReadLine(), CI);
            double y2 = double.Parse(Console.ReadLine(), CI);
            double y3 = double.Parse(Console.ReadLine(), CI);

            double px = (x1 + x2 + x3) / 2;
            double py = (y1 + y2 + y3) / 2;

            double areax = Math.Sqrt(px * (px - x1) * (px - x2) * (px - x3));
            double areay = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            } else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // ---------------------------------------------------------------------

            /* Exemplo C/ Orientação à OBJETO;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double px = (x.A + x.B + x.C) / 2;
            double py = (y.A + y.B + y.C) / 2;

            double areax = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));
            double areay = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // ---------------------------------------------------------------------------

            /* Pegando atributos da classe PESSOA e vendo quem é mais velho;
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            }
            */

            // --------------------------------------------------------------------------

            /* Pegando atributos da classe FUNCIONARIO e vendo o salário médio;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.salario = double.Parse(Console.ReadLine(), CI);

            double media = (x.salario + y.salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CI));
            */

            // -----------------------------------------------------------------------

            /* Exemplo do triângulo só que agora utilizando método (função) na classe triângulo para realizar a conta da área;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // --------------------------------------------------------

            /* Exemplo Completo: Utilizando a tabela produtos, para a atualização,
             Remoção e a multiplicação do total dos valores dos produtos.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            // ---------------------------------------------------

            /* Calcula a área, Perímetro e Diagonal de um retangulo utilizando classe própria
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            r.Largura = double.Parse(Console.ReadLine(), CI);
            r.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CI));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CI));
            */

            // ------------------------------------------------------------

            /* Aumentar o salário de um funcionário por x% utilizando a classe Trabalhador.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Trabalhador t = new Trabalhador();

            Console.Write("Nome: ");
            t.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            t.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            t.Imposto = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + t);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            t.AumentarSalario(qte);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + t);
            */

            // -------------------------------------------------------------

            /* Calcula se o aluno passou ou não, utilizando a classe Aluno
            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CI);
            a.Nota2 = double.Parse(Console.ReadLine(), CI);
            a.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CI));

            if (a.NotaFinal() < 60)
            {
                Console.WriteLine("REPROVADO");
            } else
            {
                Console.WriteLine("APROVADO");
            }
            */

            // --------------------------------------------------------------------------
            /* Se não quiser criar várias classes, pode-se criar vários static para resolver os problemas
            static double Pi = 3.14;

            static void Main(string[] args)
            {
                Console.Write("Entre o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double circ = Circunferencia(raio);
                double volume = Volume(raio);

                Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            }

            static double Circunferencia(double r)
            {
                return 2.0 * Pi * r;
            }

            static double Volume(double r)
            {
                return 4.0 / 3.0 * Pi * r * r * r;
            }
            */

            // -----------------------------------------------------

            /* Utilizasse a classe static Calculadora, assim não necessita usar o objeto.Função, usando somente o nome da classe;
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",
            CultureInfo.InvariantCulture));
            */

            // ---------------------------------------------------------------------------

            /* Exemplo de membro estático, onde basta colocar o nome da classe sem usar objetos.
            Console.Write("Qual é a cotação em dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Conversor(dolar, compra);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            // ------------------------------------------------------------------------

            /* Mesmo exemplo da classe produto só que utilizando Construtor.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Construtor personalizado: que recebe parâmetros de input de variáveis.
            Produto p = new Produto(nome, preco, quantidade);

            // Construtor padrão: s/ parâmetros.
            Produto p2 = new Produto();

            // Construtor padrão mas com valores pré definidos.
            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 10;
            }

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            // -------------------------------------------------------------------
            // UTILIZANDO A CLASSE Produto2
            /* ENCAPSULAMENTO -> GET() and SET()
            Produto2 p = new Produto2("TV", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            */

            // --------------------------------------------------------------------

            /* UTILIZANDO PROPS Produto3
            Produto3 p = new Produto3("TV", 500.00, 10);

            p.Nome = "";
            Console.WriteLine(p.Nome);
            */

            // --------------------------------------------------------------------

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titual da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char condicao = char.Parse(Console.ReadLine());

            double inicial = 0;
            if (condicao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                inicial = double.Parse(Console.ReadLine(), CI);
            }
            

            Banco b = new Banco(nome, conta, inicial);
            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(b);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            b.AdicionarDeposito(qte);
            Console.WriteLine(b);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            b.AdicionarSaque(qte);
            Console.WriteLine(b);

            b.Nome = "Eduardo";
            b.NumConta = 123213;
            b.Inicial = 231.32;



            Console.ReadLine();
        }
    }
}