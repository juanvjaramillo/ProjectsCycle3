using System;
namespace BlazorProjectIII.Shared.Entity

{
    public class Person
    {
        public int PersonId { get; set;}
        public string PersonName { get; set;}
        public DateTime BirthDate { get; set;}
        public DocumentType DocumentType { get; set;}
        public string Document { get; set;}
        public string Photo { get; set;}
        public Gender Gender { get; set;}
    }


    public enum DocumentType
    {
        CedulaCiudadana = 0,
        CedulaExtrangera = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }

    public enum Gender
    {
        Femenino = 0,
        Masculino = 1
    }
}