using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class DoctorController
    {

        private string directoryName = "ReportFiles";
        private string fileName = "Doctors.txt";

        public bool Insert(Doctor doctor)
        { 
        if( doctor == null )         
          return false;
        
        if( doctor.Id <= 0 )
          return false;

        if( string.IsNullOrWhiteSpace(doctor.DocFirstName) )
          return false;

        DataSet.Doctors.Add(doctor);

        return true;
        }
      
        public int GetNextId()
        {
          int tam = DataSet.Doctors.Count;

          if( tam > 0 )
            return DataSet.Doctors[tam - 1].Id + 1;
          else
            return 1;
        }

        public List<Doctor> List()
        {
          return DataSet.Doctors;
        }

        public List<Doctor> SearchByName(string name)
        {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Doctor> doctors = new List<Doctor>();
        for(int i = 0; i < DataSet.Doctors.Count; i++)  
        {
          var d = DataSet.Doctors[i];
          if( d.FullName.ToLower().Contains(name.ToLower()) )
          {
            doctors.Add(d);
          }
        }
        return doctors;

        }

        public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Doctor d in DataSet.Doctors)
        {
          fileContent += $"{d.Id};{d.Specialism};{d.DocFirstName};{d.DocLastName};{d.DocMail};{d.Docnumber}";
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
            Doctor doctor = new Doctor();
            string[] doctorData = line.Split(';');
            
            doctor.Id = Convert.ToInt32( doctorData[0] );
            doctor.Specialism = doctorData[1];
            doctor.DocFirstName = doctorData[2];
            doctor.DocLastName = doctorData[3];
            doctor.DocMail = doctorData[4];
            doctor.Docnumber = doctorData[5];
            
            DataSet.Doctors.Add(doctor);

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

