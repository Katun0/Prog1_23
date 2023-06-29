//Menu Clinica
string? input = string.Empty;

Console.WriteLine("------------------------");
Console.WriteLine("Atividade 02 Programação");
Console.WriteLine("------------------------");

do{
    Console.WriteLine("");
    Console.WriteLine("**************");
    Console.WriteLine("MENU DE OPÇÕES");
    Console.WriteLine("**************");
    Console.WriteLine("0 - SAIR");
    Console.WriteLine("1 - CADASTROS");
    Console.WriteLine("2 - RELATORIO");


    input = Console.ReadLine();
switch (input)
{
    case "1":
        string? choose = string.Empty;
        Console.WriteLine("*****************");
        Console.WriteLine("Menu de cadastros");
        Console.WriteLine("*****************");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("1 - ANIMAIS");
        Console.WriteLine("2 - DOUTORES");
        Console.WriteLine("3 - ATENDIMENTO");
        switch(choose)
        {
            case "1":
            Console.Write("Nome do paciente:");
            string? animal_name = Console.ReadLine();
            Console.Write("Espécie do animal:");
            string? animal_specie = Console.ReadLine();
            Console.Write("Raça:");
            string? animal_race = Console.ReadLine();
            
            break;
            
            case "2":
            Console.Write("Nome do doutor:");
            string? doctor_name = Console.ReadLine();
            Console.Write("Função:");
            string? doctor_funcion = Console.ReadLine();
            
            break;

            case "3":
            Console.Write("Tipo de Operação:");
            string? operation_type = Console.ReadLine();
            Console.Write("Doutor responsável:");
            string? operation_doctor = Console.ReadLine();
            
            break;
        }
            break;
    case "2":
        Console.WriteLine("Menu de Relatórios");
        break;
    case "0":
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}   
}while(Convert.ToInt32(input) > 0);
