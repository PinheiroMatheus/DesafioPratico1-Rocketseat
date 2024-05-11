// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite o número do desafio(1 ~ 6) que queira ver:");
string numDesafio = Console.ReadLine();

switch (numDesafio)
{
	case "1":
        Desafio1();
			break;
    case "2":
        Desafio2();
            break;
    case "3":
        Desafio3();
        break;
    case "4":
        Desafio4();
        break;
    case "5":
        Desafio5();
        break;
    case "6":
        Desafio6();
        break;
    default:
        Console.WriteLine("Você não digitou uma opção válida!");
		break;
}

void Desafio1()
{
    Console.WriteLine("\nBem-vindo ao desafio 1!");
    Console.WriteLine("\nDigite seu nome:");

    string userName = Console.ReadLine();

    Console.WriteLine("\nOlá, " + userName + "! Seja muito bem-vindo!");
}

void Desafio2()
{
    Console.WriteLine("\nBem-vindo ao desafio 2!");
    Console.WriteLine("\nDigite o seu primeiro nome:");

    string firstName = Console.ReadLine();

    Console.WriteLine("\nAgora digite o seu sobrenome:");

    string lastName = Console.ReadLine();

    Console.WriteLine("\nO seu nome completo é " + firstName + " " +  lastName);
}

void Desafio3()
{
    Console.WriteLine("\nBem-vindo ao desafio 3!");

    double value1;
    string input1;

    do
    {
        Console.WriteLine("\nDigite o primeiro valor:");
        input1 = Console.ReadLine();
    } while (!double.TryParse(input1, out value1));

    double value2;
    string input2;

    do
    {
        Console.WriteLine("\nDigite o segundo valor:");
        input2 = Console.ReadLine();
    } while (!double.TryParse(input2, out value2));

    Console.WriteLine("\nO primeiro valor utilizado é " + value1);
    Console.WriteLine("O segundo valor utilizado é " + value2);

    double sum = value1 + value2;
    double sub = value1 - value2;
    double mult = value1 * value2;
    double div = value1 / value2;
    double avg = (value1 + value2) / 2;

    Console.WriteLine("\nO resultado da soma é " + sum);
    Console.WriteLine("O resultado da subtração é " + sub);
    Console.WriteLine("O resultado da multiplicação é " + mult);
    Console.WriteLine("O resultado da divisão é " + div);
    Console.WriteLine("O resultado da média é " + avg);
}

void Desafio4()
{
    Console.WriteLine("\nBem-vindo ao desafio 4!");

    Console.WriteLine("\nDigite um texto:");

    string text = Console.ReadLine();

    Console.WriteLine("\nO seu texto tem " + text.Length + " caracteres.");
}

void Desafio5()
{
    Console.WriteLine("\nBem-vindo ao desafio 5!");

    bool isValid = false;

    do
    {
        Console.WriteLine("\nDigite a placa do veículo que deseja verificar se é verdadeira:");

        string plate = Console.ReadLine();
        int lastDigits;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;

        //Validação 1
        valid1 = plate.Length == 7 ? true : false;

        //Validação 2
        valid2 = char.IsLetter(plate[0]) ? true : char.IsLetter(plate[1]) ? true : char.IsLetter(plate[2]) ? true: false;

        //Validação 3
        valid3 = int.TryParse(plate.Substring(3, 4), out lastDigits);

        if (valid1 && valid2 && valid3) {
            Console.WriteLine("Verdadeiro");
            isValid = true;
        }
        else
        {
            Console.WriteLine("Falso");
        };
    } while (!isValid);
}

void Desafio6()
{
    Console.WriteLine("\nBem-vindo ao desafio 6!");

    Console.WriteLine("\nVocê deseja ver a data em qual formato a seguir? Digite apenas o número:\n1. Completo\n2. Padrão\n3. Hora\n4. Mês por extenso\n");
    string choise = Console.ReadLine();

    DateTime dataAtual = DateTime.Now;

    switch (choise)
    {
        case "1":
            string dataModificada = dataAtual.ToString("dddd dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(dataModificada);
            break;
        case "2":
            string dataModificada2 = dataAtual.ToString("dd/MM/yyyy");
            Console.WriteLine(dataModificada2);
            break;
        case "3":
            string dataModificada3 = dataAtual.ToString("HH:mm");
            Console.WriteLine(dataModificada3);
            break;
        case "4":
            string dataModificada4 = dataAtual.ToString("dd/MMMM/yyyy");
            Console.WriteLine(dataModificada4);
            break;
        default:
            Console.WriteLine("Você não digitou um valor correto");
            break;
    }
}