using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;
        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Cadastro de Animais");
            Console.WriteLine("*********************");
            Console.WriteLine("");
<<<<<<< HEAD
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar arquivo de texto");
            Console.WriteLine("4 - Importar arquivo de texto");
            Console.WriteLine("5 - Pesquisar animais por nome");
            Console.WriteLine("0 - Retornar para o menu principal");
            
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
            
=======
            Console.WriteLine("1 - Inserir Animais");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
            switch(option) 
            {
                case 1:
                    Insert();
<<<<<<< HEAD
                    Thread.Sleep(2000);
                    break;
                
                case 2:
                    List();
                    Thread.Sleep(2000);
                    break;
                
                case 3:
                    Export();
                    break;
                
                case 4:
                    Import();
                    break;
                
                case 5:
                    SearchByName();
                    Thread.Sleep(2000);
                    break;
                
                default:
                break;
            }
        }
        //Listagem dos dados
=======
                break;

                case 2:
                    List();
                break;
                default:
                
                break;
            }
        }

>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
        private void List()
        {
            List<Animal> listagem = animalController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }
<<<<<<< HEAD
        //Tabela de dados impressos 
        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += "-------------------------------------------\n";
=======

        private string Print(Animal animal)
        {
            string retorno = "";
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Nome: {animal.AnimalName} \n";
            retorno += $"Espécie: {animal.Specie} \n";
            retorno += $"Raça: {animal.Race} \n";
<<<<<<< HEAD
            retorno += "-------------------------------------------";
            Thread.Sleep(1000);

            return retorno;
        }
        //Método de Inserção animais
        private void Insert()
        {
            Animal animal = new Animal();
            
            animal.Id = animalController.GetNextId();
            
            Console.WriteLine("Informe o nome do animal: ");
            animal.AnimalName = Console.ReadLine();
            Console.WriteLine("Registrando Nome do animal... Aguarde um segundo");
            Thread.Sleep(1000);

            Console.WriteLine("Informe a espécie: ");
            animal.Specie = Console.ReadLine();
            Console.WriteLine("Registrando a Espécie... Aguarde um segundo");
            Thread.Sleep(1000);

            Console.WriteLine("Informe a raça: ");
            animal.Race = Console.ReadLine();
            Console.WriteLine("Registrando Raça... Aguarde um segundo");
            Thread.Sleep(1000);
            
=======
            retorno += $"Idade: {animal.Age} \n";
            retorno += "-------------------------------------------";

            return retorno;
        }
        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextID();

            Console.WriteLine("Informe o nome do animal: ");
            animal.AnimalName = Console.ReadLine();
            
            Console.WriteLine("Informe a espécie: ");
            animal.Specie = Console.ReadLine();
            
            Console.WriteLine("Informe a raça: ");
            animal.Race = Console.ReadLine();
            
            Console.WriteLine("Informe A idade: ");
            animal.Age = Console.ReadLine();

>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("Animal registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }
<<<<<<< HEAD
        //Método de exportação para arquivo .TXT
        private void Export()
        {
            if( animalController.ExportToTextFile() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops.");
        }

        private void Import()
        {
            if(animalController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
        //Método de pesquisa pelo nome
        private void SearchByName()
        {
            Console.WriteLine("Pesquisar o animal pelo nome.");
            Console.WriteLine("Digite o nome:");
            string? AnimalName = Console.ReadLine();

            foreach( Animal a in 
                animalController.SearchByName(AnimalName) )
            {
                Console.WriteLine("-------------------\n");
                Console.WriteLine( a.ToString() );
                Console.WriteLine("-------------------\n");
            }
        }
=======
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
    }
}