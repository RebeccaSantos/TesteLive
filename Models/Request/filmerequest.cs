using System;
namespace TesteLive.Models.Request
{
    public class filmerequest
        {
            public string Filme{get;set;}
            public string Genero{get;set;}

            public decimal Avaliacao{get;set;}
            public bool Disponivel {get;set;}
            public decimal Duracao{get;set;}
            public DateTime Lançamento{get;set;}

    }
}