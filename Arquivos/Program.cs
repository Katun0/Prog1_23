<<<<<<< HEAD
﻿﻿using Arquivos.Views;
=======
﻿using Arquivos.Views;
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
using Arquivos.Utils;

/*
    Programa para leitura de dados de pessoas
    e exportação em arquivo .txt
*/
Bootstrapper.ChargeClients();
<<<<<<< HEAD
Bootstrapper.ChargeAnimals();
Bootstrapper.ChargeDoctors();
Bootstrapper.ChargeClinics();
=======

>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");    
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
<<<<<<< HEAD
    Console.WriteLine("3 - Doutores");
    Console.WriteLine("4 - Clínicas");
    Console.WriteLine("0 - Sair do Programa");
    
    string? userInput =Console.ReadLine(); 
    bool isValid = Int32.TryParse(userInput, out option);

    if(!isValid)
    {
        Console.WriteLine("Não foi possível converter para valor númerico, favor inserir uma das opções acima");
        continue;
    }
    switch(option)
    {
        case 1:
            Console.WriteLine("Redirecionando para CLIENTES ");
            Thread.Sleep(1000);
            ClientView clientView = new ClientView();
        break;

        case 2:
            Console.WriteLine("Redirecionando para ANIMAIS");
            Thread.Sleep(1000);
            AnimalView animalView = new AnimalView();
        break;

        case 3:
            Console.WriteLine("Redirecionando para DOUTORES");
            Thread.Sleep(1000);
            DoctorView doctorView = new DoctorView();
        break;
        
        case 4:
            Console.WriteLine("Redirecionando para CLÍNICAS");
            Thread.Sleep(1000);
            ClinicView clinicView = new ClinicView();
        break;
    }
}
while(option!=0);

Console.Write("Saindo do Programa...");
=======
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clínica");
    Console.WriteLine("0 - Sair");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("Cadastro de Clientes");
            ClientView clientView = new ClientView();
            break;

        case 2 :
            Console.WriteLine("Cadastro de Animais");
            AnimalView animalView = new AnimalView();
            break;
        case 3:
            Console.WriteLine("Cadastro de Veterinários");
            //Insira o método de Cadastro
            break;        
        case 4:
            Console.WriteLine("Cadastro de Clínicas");
            //Insira o método de Cadastro
            break;
    }
}
while( option > 0 );
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
