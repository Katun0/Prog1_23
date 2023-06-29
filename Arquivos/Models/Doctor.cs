using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Doctor
    {
        public Doctor(int id,
         string? docFirstName,
          string? docLastName,
           string? specialism,
            string? docMail,
             string? docnumber)
        {
            Id = id;
            DocFirstName = docFirstName;
            DocLastName = docLastName;
            Specialism = specialism;
            DocMail = docMail;
            Docnumber = docnumber;
        }
        public Doctor()
        {

        }

        public int Id { get; set; }
        public string? DocFirstName { get; set; }
        public string? DocLastName { get; set; }
        public string? Specialism { get; set; }
        public string? DocMail { get; set; }
        public string? Docnumber {get; set;}

        public string FullName => 
            $"{this.DocFirstName} {this.DocLastName}";


        public override string ToString()
        {   
            return $"Id: {this.Id};\nName: {this.FullName};\nContato {this.Docnumber}; ";
        }

    }

}