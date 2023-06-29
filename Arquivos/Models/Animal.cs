using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
<<<<<<< HEAD

    public class Animal
    {
        
        public int Id {get; set;}
        public string? AnimalName {get; set;}
        public string? Specie {get; set;}
        public string? Race {get; set;}

        public Animal(int id, 
        string? animalName, 
        string? specie, 
        string? race)
=======
    public class Animal
    {
        public Animal(int id,
        string? animalName,
        string? specie,
        string? race,
        string? age)
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
        {
            Id = id;
            AnimalName = animalName;
            Specie = specie;
            Race = race;
<<<<<<< HEAD
        }
        public Animal()
        {

        }

        public override string ToString()
        {   
            return $"Id: {this.Id}; Nome: {AnimalName} ";
        }
=======
            Age = age;
        }

        public Animal()
        {
            
        }

        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Specie { get; set; }
        public string? Race { get; set; }
        public string? Age { get; set; }
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
    }
}