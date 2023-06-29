<<<<<<< HEAD
=======
using Arquivos.Models;
using Arquivos.Data;
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Arquivos.Models;
using Arquivos.Data;
=======
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f

namespace Arquivos.Controllers
{
    public class AnimalController
    {
<<<<<<< HEAD
      private string directoryName = "ReportFiles";
      private string fileName = "Animals.txt";
      public bool Insert(Animal animal)
      { 
        if( animal == null )         
          return false;
        
        if( animal.Id <= 0 )
          return false;

        if( string.IsNullOrWhiteSpace(animal.AnimalName) )
          return false;

        DataSet.Animals.Add(animal);

        return true;
      }        
      public List<Animal> List()
      {
          return DataSet.Animals;
      }

      public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Animal a in DataSet.Animals)
        {
          fileContent += $"{a.Id};{a.AnimalName};{a.Specie};{a.Race};";
          fileContent += "\n";
        }

        try
        {
          StreamWriter sw = File.CreateText( 
            $"{directoryName}\\{fileName}" 
          );

          sw.Write(fileContent);
          sw.Close();        
        }
        catch(IOException ioEx)
        {
          Console.WriteLine("Erro ao manipular o arquivo.");
          Console.WriteLine(ioEx.Message);
          return false;
        }
        
        return true;
      }

      public bool ImportFromTxtFile()
      {
        try
        {
          StreamReader sr = new StreamReader(
            $"{directoryName}\\{fileName}"
          );
          
          string? line = sr.ReadLine();
          while(line != null)
          {
            Animal animal = new Animal();
            string[] animalData = line.Split(';');
            animal.Id = Convert.ToInt32( animalData[0] );
            animal.AnimalName = animalData[1];
            animal.Specie = animalData[2];
            animal.Race = animalData[3];
            

            DataSet.Animals.Add(animal);

            line = sr.ReadLine();
          }

          return true;
        }

        catch(Exception ex)
        {
          Console.WriteLine("Ooops. Ocorreu um erro ao tentar importar os dados.");
          Console.WriteLine(ex.Message);
          return false;
        }
      }

      public int GetNextId()
      {
          int tam = DataSet.Animals.Count;

          if( tam > 0 )
            return DataSet.Animals[tam - 1].Id + 1;
          else
            return 1;
      } 

      public List<Animal> SearchByName(string AnimalName)
      {
        if ( string.IsNullOrEmpty(AnimalName) ||
             string.IsNullOrWhiteSpace(AnimalName) 
           )
           return null;
       
        List<Animal> animals = new List<Animal>();
        for(int i = 0; i < DataSet.Animals.Count; i++)  
        {
          var a = DataSet.Animals[i];
          if( a.AnimalName.ToLower().Contains(AnimalName.ToLower()) )
          {
            animals.Add(a);
          }
        }
        return animals;

      }
    }   
}
=======
        public int GetNextID()
        {
            int tam = DataSet.Animals.Count;
            if(tam > 0)
                return DataSet.Animals[tam-1].Id+1;
            else
                return 1; 
        }
        public bool Insert(Animal animal)
        {
            if( animal == null )
                return false;

            if( animal.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(animal.AnimalName) )
                return false;

            DataSet.Animals.Add(animal);

            return true;
        }
        public List<Animal> List()
        {
            return DataSet.Animals;
        }
    }
}
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
