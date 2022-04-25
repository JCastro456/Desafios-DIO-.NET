using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse {
  public static void Main (string[] args) {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

    for(int numeroDetestes = 0; numeroDetestes < totalDeCasosDeTeste; numeroDetestes++)
    {

        string[] valores = Console.ReadLine().Split();
        var ListadeComprasFiltradaOrganizada = new List<string>();

    for (int i = 0; i < (valores.GetLength(0)) ; i++)
    {
        ListadeComprasFiltradaOrganizada.Insert(i, valores[i]);
    }
    ListadeComprasFiltradaOrganizada = ListadeComprasFiltradaOrganizada.Distinct().ToList();
    ListadeComprasFiltradaOrganizada.Sort();
    for (int i = 0; i < (ListadeComprasFiltradaOrganizada.Count) ; i++)
    {
        Console.Write(ListadeComprasFiltradaOrganizada[i]+" ");
    }
    Console.WriteLine("");

    }
  }
}