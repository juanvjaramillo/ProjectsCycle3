using System;
namespace BlazorProjectIII.Shared.Entity

{
    public class Person
    {
        public string PersonName {get;set;}
        public DateTime BirthDate {get;set;}
        /* public enum DocumentType{get;set;} */
        public string DocumentType{get;set;}
        public string Document{get;set;}
        public string Photo{get;set;}
        public string Gender{get;set;}
    }

    
    public enum EnuDocument
    {
        enuCedulaCiudadana,
        enuCedulaExtrangera,
        enuPasaporte,
        enuRegistroCivil
    }

    public enum Gender{Femenino, Masculino}
}