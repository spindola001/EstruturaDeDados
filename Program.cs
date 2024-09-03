using EstruturaDeDados.Array;

namespace EstruturaDeDados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------- INICIO DE EXECUÇÃO DE EXERCÍCIOS DE ESTRUTURA DE DADOS ---------------------------------------------------------------");
            Console.WriteLine("ESCOLHA UMA OPÇÃO DE EXERCÍCIO PARA EXECUTAR: ");
            Console.WriteLine("1- BUSCA EM UM ARRAY DE INTEIROS");
            Console.WriteLine("2- ORDENAR UM ARRAY DE INTEIROS");
            Console.WriteLine("3- BUSCA EM UM ARRAY DE STRINGS");
            Console.WriteLine("4- ORDENAR UM ARRAY DE STRINGS");
            Console.WriteLine("0- Sair");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            int.TryParse(Console.ReadLine(), out int option);
            
            var arrMethods = new ArrayExercicios();

            ExecuteMethod(option, arrMethods);
        }

        public static void ExecuteMethod(int option, ArrayExercicios parameters)
        {
            switch (option)
            {
                case 1:
                    {
                        var result = parameters.LinearSearchAlgIntegerData(parameters.arrayIntegerExample, 14);
                        if (result < 0)
                            Console.WriteLine("Não encontramos o valor dentro do Array...");
                        else
                            Console.WriteLine($"Valor encontrado na posição {result} do array!");
                    }
                    break;
                case 2:
                    {
                        var result = string.Join(", ", parameters.InsertionSortAlgIntegerData(parameters.arrayIntegerExample));
                        Console.WriteLine($"Array reordenado: [ {result} ]");
                    }
                    break;
                case 3:
                    {
                        var result = parameters.LinearSearchAlgStringData(parameters.arrayStringExample, "Marcio");
                        if (result < 0)
                            Console.WriteLine("Não encontramos o valor dentro do Array...");
                        else
                            Console.WriteLine($"Valor encontrado na posição {result} do array!");
                    }
                    break;
                case 4:
                    {
                        var result = string.Join(", ", parameters.InsertionSortAlgStringData(parameters.arrayStringExample));
                        Console.WriteLine($"Array reordenado: [ {result} ]");
                    }
                    break;                    
                default:
                    break;
            }
        }
    }
}