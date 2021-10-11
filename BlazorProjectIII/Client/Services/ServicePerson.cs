using System;
using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public class ServicePerson : IServicePerson 
    {
        public List<Person> GetPerson(){
            return new List<Person>(){
                new Person(){PersonId=1, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person1.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=2, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person2.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=3, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person3.jpg", Gender=Gender.Masculino},
                new Person(){PersonId=4, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person4.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=5, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person5.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=6, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person6.jpg", Gender=Gender.Masculino},
                new Person(){PersonId=7, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person7.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=8, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person8.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=9, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person9.jpg", Gender=Gender.Femenino},
                new Person(){PersonId=10, PersonName="Person 1", BirthDate=new DateTime(1986,10,10), DocumentType=DocumentType.CedulaCiudadana, Document="24300355", Photo="/images/persons/person10.jpg", Gender=Gender.Masculino}
            };
        }
    }
}
