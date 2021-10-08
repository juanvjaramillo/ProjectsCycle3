using System;
using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public class ServicePerson : IServicePerson 
    {
        public List<Person> GetPerson(){
            return new List<Person>(){
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person1.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person2.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person3.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person4.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person5.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person6.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person7.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person8.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person9.jpg", Gender="Femenino"},
                new Person(){PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=FStrDocumneto(EnuDocument.enuCedulaCiudadana), Document="24300355", Photo="/images/persons/person10.jpg", Gender="Femenino"}
            };
        }

        public string FStrDocumneto(EnuDocument DocumentType){
            string strDocType = "";
            if(DocumentType==EnuDocument.enuCedulaCiudadana){
                strDocType = "Cédula de ciudadania";
            }
            return strDocType;
        }
    }
}
