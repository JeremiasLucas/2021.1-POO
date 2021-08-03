using System;

class MainClass {
  private static NTipo ntipo = new NTipo();
  public static void Main() {
    int op = 0;
    Console.WriteLine("------ Aplicativo para Pizzarias ------");
    do {
      try {
        op = Menu();
        switch(op) {
          case 1 : TipoListar(); break;
          case 2 : TipoInserir(); break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
        op = 100;
      }
    } while (op != 0);
    Console.WriteLine ("Bye.....");

  }
  public static int Menu() {
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1 - Tipo Listar");
    Console.WriteLine("2 - Tipo Inserir");
    Console.WriteLine("0 - Fim");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static void TipoListar() {
    Console.WriteLine("------Lista de tipos de pizzas------");
    Tipo[] ts = ntipo.Listar();
    if (ts.Length == 0) {
      Console.WriteLine("Nenhum tipo de pizza cadastrado");
      return;
    }
    foreach(Tipo t in ts) Console.WriteLine(t);
    Console.WriteLine();
  }
  public static void TipoInserir() {
    Console.WriteLine("------Inserção de tipos de pizzas------");
    Console.Write("Informe um código para o tipo: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe uma descrição: ");
    string descrição = Console.ReadLine();
    // Instanciar a classe de Tipos
    Tipo t = new Tipo(id, descrição);
    // Inserção dos Tipos
    ntipo.Inserir(t);
  }
}

