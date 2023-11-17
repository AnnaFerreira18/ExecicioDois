using System;
using System.Drawing;

class Program
{ /**
   //QUESTAO 01
    static void Main()
    {
        double raio;
        double area;
        double perimetro;

        Console.WriteLine(" Digite o raio do circulo: ");
        raio = double.Parse(Console.ReadLine());
        Circulo circulo = new Circulo (raio);

        area = circulo.area();
        Console.WriteLine(" A area do circulo é: " + area );

        perimetro = circulo.perimetro();
        Console.WriteLine(" O perimetro do circulo é: " + perimetro );
    }
    class Circulo
    {
        double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double area()
        {
            return 3.14 * Math.Pow(raio, 2);
        }
        public double perimetro()
        {
            return 2 * 3.14 * raio;
        }
    } 

    /**
    //QUESTAO02
    static void Main()
    {
        double largura;
        double altura;
        double area;
        double perimetro;

        Console.WriteLine(" Digite a largura do retangulo: ");
        largura = double.Parse(Console.ReadLine());

        Console.WriteLine(" Digite a altura do retangulo: ");
        altura = double.Parse(Console.ReadLine());

        retangulo retangulo = new retangulo(largura, altura);

        area = retangulo.area();
        Console.WriteLine(" A area é: " + area);

        perimetro = retangulo.perimetro();
        Console.WriteLine(" O perimetro é: " + perimetro);

    }
    class retangulo
    {
        public double largura;
        public double altura;

        public retangulo (double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public double area()
        {
            return largura * altura;
        }
        public double perimetro()
        {
            return 2 * (altura + largura);
        }
    }**/
    /**
     //QUESTAO03
    static void Main()
    {
        string nome;
        int matricula;
        int numeroNotas;

        Console.WriteLine("Informe os dados do aluno >>> ");

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Matrícula: ");
        matricula = int.Parse(Console.ReadLine());

        Console.Write("Número de notas: ");
        numeroNotas = int.Parse(Console.ReadLine());

        double[] notas = new double[numeroNotas];
        for (int i = 0; i < numeroNotas; i++)
        {
            Console.Write("Nota: " +(i + 1)); 
            notas[i] = int.Parse(Console.ReadLine());
        }

        Aluno aluno = new Aluno(nome, matricula, notas);

        Console.WriteLine("Média do aluno " + aluno.nome + ": " + aluno.CalcularMedia());
        Console.WriteLine("Situação do aluno " + aluno.nome + ": " + aluno.Verificar());


    }
    class Aluno
    {
        public string nome;
        public int matricula;
        double[] notas;

        public Aluno(string nome, int matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }
        public double CalcularMedia()
        {
            double soma = 0;
            foreach (var nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }
        public string Verificar()
        {
            double media = CalcularMedia();

            if (media >= 6.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
    **/
    /**
    // QUESTAO 04
    //nao consegui corrigir esse codigo
    static void Main()
    {
        int numeroInformado;

        Console.Write("Informe um número para calcular o fatorial: ");
        numeroInformado = int.Parse(Console.ReadLine());

        Numero numero = new Numero(numeroInformado);

        long resultadoFatorial = numero.CalcularFatorial();
        Console.WriteLine("O fatorial de" + numeroInformado + "é:" +resultadoFatorial+ );
    }

   
    class Numero
    {
        public int Valor {  get; set; }

    }
    public Numero(int valor)
    {
        Valor = valor;
    }

    // Método para calcular o fatorial do número
    public long CalcularFatorial()
    {
        if (valor < 0)
        {
            Console.WriteLine("Erro: O fatorial é indefinido para números negativos.");
            return -1;
        }

        long resultado = 1;
        for (int i = 2; i <= valor; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
    **/
    /**
     //QUESTAO 05
    static void Main()
    {
        Sorteio sorteio = new Sorteio();
        int numeroUsuario;

        do
        {
            Console.Write("Digite um número de 0 a 10: ");
            string Numero = Console.ReadLine();

            if (int.TryParse(Numero, out numeroUsuario) && numeroUsuario >= 0 && numeroUsuario <= 10)
            {
                sorteio.RealizarSorteio(numeroUsuario);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido entre 0 e 10.");
            }

        } while (numeroUsuario != sorteio.NumeroSorteado);
    }
    class Sorteio
    {
        private int numeroSorteado;
        private int tentativas;

        public Sorteio()
        {
            Random random = new Random();

            numeroSorteado = random.Next(11);

            tentativas = 0;
        }

        public int NumeroSorteado
        {
            get {return numeroSorteado; }
        }

        public void RealizarSorteio(int numeroUsuario)
        {
            tentativas++;

            if (numeroUsuario == numeroSorteado)
            {
                Console.WriteLine("Você acertou o número" + numeroSorteado + " em " + tentativas + "tentativa(s).");
            }
            else
            {
                Console.WriteLine("Você errou. Tente novamente.");
            }
        }
    }
    **/
}




