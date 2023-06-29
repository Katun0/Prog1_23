using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinic
    {
        public Clinic(int id,
        string? name,
        string? owner,
        string? cNPJ,
        string? city,
        string? country,
        string? cEP,
        string? phone
        )
        {
            Id = id;
            Name = name;
            Owner = owner;
            CNPJ = cNPJ;
            City = city;
            Country = country;
            CEP = cEP;
            Phone = phone;
        }


        public Clinic()
        {

        }

        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Owner {get; set;}
        public string? CNPJ {get; set;}
        public string? City {get; set;}
        public string? Country {get; set;}
        public string? CEP {get; set;}
        public string? Phone {get; set;}

        
        public override string ToString()
        {   
            return $" Id: {this.Id};\n Name: {this.Name};\n Contato: {this.Phone}; \n Dono: {this.Owner}";
        }
    }
}