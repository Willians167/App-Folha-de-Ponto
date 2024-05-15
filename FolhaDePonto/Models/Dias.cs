
using System;
namespace FolhaDePonto.Models;

public class Dias
{
public int Id { get; set; }
public int Dia { get; set; }           

public DateTime Entrada { get; set; }
public DateTime Descanso { get; set; }
public DateTime Retorno {get; set;}
public DateTime Saida { get; set; }

}