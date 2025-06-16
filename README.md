# CalculSwitch2

// Exemplo de uma função auxiliar para leitura de valores com validação
static int LerValor(string mensagem)
{
    int valor;
    Console.WriteLine(mensagem);
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Entrada inválida. Por favor, informe um número válido:");
    }
    return valor;
}

  Console.WriteLine("----Escolha uma opção: ------");
        Console.WriteLine("1. ADIÇÃO");
        Console.WriteLine("2. SUBTRAÇÃO");
        Console.WriteLine("3. DIVISÃO");
        Console.WriteLine("4. MULTIPLICAÇÃO");

  op = Convert.ToInt32(Console.ReadLine());

       
  switch (op)
        {
            case 1://soma
                Console.WriteLine("Informe o valor1: ");
                val1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Informe o valor2: ");
                val2 = Convert.ToInt32(Console.ReadLine());

  total = val1 + val2;
                Console.WriteLine("Total da soma: " + total);
                break;
            case 2://subtração
                Console.WriteLine("Informe o valor1: ");
                val1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Informe o valor2: ");
                val2 = Convert.ToInt32(Console.ReadLine());

  total = val1 - val2;
                Console.WriteLine("Total da subtração: " + total);
                break;
            case 3://divisão
                Console.WriteLine("Informe o valor1: ");
                val1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Informe o valor2: ");
                val2 = Convert.ToInt32(Console.ReadLine());

  //analisar se o val2 é igual a zero
                if (val2 == 0)
                {
                    Console.WriteLine("O val2 não pode ser zero!\n" +
                        "Informe novos valores!");
                    Console.WriteLine("Val1: ");
                    val1= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Val2: ");
                    val2= Convert.ToInt32(Console.ReadLine());
                    total= val1 /val2;
                    Console.WriteLine("Total da divisão: " + total);
                }
                else
                {
                    total = val1 / val2;
                    Console.WriteLine("Total da divisão: " + total);
                }
                break;
               
 case 4://multiplicação
                Console.WriteLine("Informe o valor1: ");
                val1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Informe o valor2: ");
                val2 = Convert.ToInt32(Console.ReadLine());

  total = val1 * val2;
                Console.WriteLine("Total da multiplicação: " + total);
                break;
            default:
                Console.WriteLine("Opção inválida!\n" +
                    "Escolha entre 1 a 4.");
                break;
        }
        Console.ReadKey();
    }
}
