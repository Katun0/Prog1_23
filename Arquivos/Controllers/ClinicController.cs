using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Controllers
{
    public class ClinicController
    {
         private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";


        public bool Insert(Clinic clinic)
        { 
        if( clinic == null )         
          return false;
        
        if( clinic.Id <= 0 )
          return false;

        if( string.IsNullOrWhiteSpace(clinic.Name) )
          return false;

        DataSet.Clinic.Add(clinic);

        return true;
        }
      public List<Clinic> List()
        {
          return DataSet.Clinic;
        }

        public List<Clinic> SearchByName(string name)
        {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Clinic> clinics = new List<Clinic>();
        for(int i = 0; i < DataSet.Clinic.Count; i++)  
        {
          var c = DataSet.Clinic[i];
          if( c.Name.ToLower().Contains(name.ToLower()) )
            {
                clinics.Add(c);
            }
        }
        return clinics;

        }


      public int GetNextId()
        {
          int tam = DataSet.Clinic.Count;

          if( tam > 0 )
            return DataSet.Clinic[tam - 1].Id + 1;
          else
            return 1;   
        }

        public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Clinic c in DataSet.Clinic)
        {
          fileContent += $"{c.Id};{c.CNPJ};{c.Name};{c.Owner};{c.CNPJ};{c.City};{c.Country};{c.CEP};{c.Phone}";
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
            Clinic clinic = new Clinic();
            string[] clinicData = line.Split(';');
            clinic.Id = Convert.ToInt32( clinicData[0] );
            clinic.Name = clinicData[1];
            clinic.Owner = clinicData[2];
            clinic.CNPJ = clinicData[3];
            clinic.City = clinicData[4];
            clinic.Country = clinicData[5];
            clinic.CEP = clinicData[6];
            clinic.Phone = clinicData[7];

            DataSet.Clinic.Add(clinic);

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
    }
}