using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Mauricio Roberto",
                LastName = "Gonzatto",
                CPF = "000.000.000-00",
                Email = "mauricio.gonzatto@unoesc.edu.br"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000.000-01",
                    Email = "eduardo.blank@unoesc.edu.br"                    
                }
            );

             DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Timóteo",
                    CPF = "000.000.000-02",
                    Email = "aguinaldo@unoesc.edu.br"                    
                }
            );            

        }
<<<<<<< HEAD
        public static void ChargeAnimals()
        {
            var a1 = new Animal{
                Id = 1,
                AnimalName = "Millo",
                Specie = "Cachorro",
                Race = "Pug",
            };
            DataSet.Animals.Add(a1);

            DataSet.Animals.Add(
                new Animal{
                    Id = 2,
                    AnimalName = "Bill",
                    Specie = "Cachorro",
                    Race = "Pug",                    
                }
            );

            DataSet.Animals.Add(
                new Animal{
                    Id = 3,
                    AnimalName = "Wendy",
                    Specie = "Cahorro",
                    Race = "Maltes",                                    
                }
            );
        }
         public static void ChargeDoctors()
        {
            var d1 = new Doctor{
                Id = 1,
                DocFirstName = "Paulo",
                DocLastName = "Muzy",
                DocMail = "muzypaulo@hotmail.com",
                Docnumber = "0000000001",
                Specialism = "Dermatologia"
            };
            DataSet.Doctors.Add(d1);

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 2,
                    DocFirstName = "Bill",
                    DocLastName = "Parker",
                    DocMail = "parkerbill@hotmail.com",
                    Docnumber = "0000000002",
                    Specialism = "Apucuntura"
                }
            );

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 3,
                    DocFirstName = "Wendy",
                    DocLastName = "Lee",
                    DocMail = "lee@yahoo.com.br",
                    Docnumber = "0000000003",
                    Specialism = "Analise Clínica"                                    
                }
            );
        }

        public static void ChargeClinics()
        {
            var c1 = new Clinic{
                Id = 1,
                Name = "Clinica Peixe Seco",
                Owner = "Alberto",
                CNPJ = "00.000.000/0001-01",
                City = "Videira",
                Country = "SC",
                CEP = "895600-000",
                Phone = "3566-3535"
            };
            DataSet.Clinic.Add(c1);

            DataSet.Clinic.Add(
                new Clinic{
                    Id = 2,
                    Name = "Clinica Pinguim Ajoelhado",
                    Owner = "Alana",
                    CNPJ = "00.000.000/0001-02",
                    City = "Videira",
                    Country = "SC",
                    CEP = "895600-000",
                    Phone = "3566-3639"
                }
            );

            DataSet.Clinic.Add(
                new Clinic{
                    Id = 3,
                    Name = "Hospital Canino do Xang",
                    Owner = "Xang lee",
                    CNPJ = "00.000.000/0001-03",
                    City = "Curitiba",
                    Country = "PR",
                    CEP = "80001-970",
                    Phone = "3566-5566"                                  
                }
            );
        }
=======
>>>>>>> 3c09164380b5c16fd6c0178e1c9c0584ae89e97f
    }
}