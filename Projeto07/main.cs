using System;

class MainClass {
  private static NTipo ntipo = new NTipo();
  private static NPizza npizza = new NPizza();
  public static void Main() {
    int op = 0;
    Console.WriteLine("------ Aplicativo para Pizzarias ------");
    do {
      try {
        op = Menu();
        switch(op) {
          case 1 : TipoListar(); break;
          case 2 : TipoInserir(); break;
          case 3 : TipoAtualizar(); break;
          case 4 : TipoExcluir(); break;
          case 5 : PizzaListar(); break;
          case 6 : PizzaInserir(); break;
          case 7 : PizzaAtualizar(); break;
          case 8 : PizzaExcluir(); break;
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
    Console.WriteLine("3 - Tipo Atualizar");
    Console.WriteLine("4 - Tipo Excluir");
    Console.WriteLine("5 - Pizza Listar");
    Console.WriteLine("6 - Pizza Inserir");
    Console.WriteLine("7 - Pizza Atualizar");
    Console.WriteLine("8 - Pizza Excluir");
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
  public static void TipoAtualizar(){
    Console.WriteLine("------Atualização de tipos de pizzas------");
    TipoListar();
    Console.Write("Informe um código para alterar o tipo de pizza: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe uma descrição: ");
    string descrição = Console.ReadLine();
    // Instanciar a classe de Tipos
    Tipo t = new Tipo(id, descrição);
    // Atualização dos Tipos
    ntipo.Atualizar(t);
  }
  public static void TipoExcluir(){
    Console.WriteLine("------Exclusão de tipos de pizzas------");
    TipoListar();
    Console.Write("Informe um código para excluir o tipo de pizza: ");
    int id = int.Parse(Console.ReadLine());
    // Procurar o tipo com esse id
    Tipo t = ntipo.Listar(id);
    // Exclui o tipo de pizza do cadastro
    ntipo.Excluir(t);
  }
  public static void PizzaListar() {
    Console.WriteLine("------Lista de pizzas------");
    Pizza[] ps = npizza.Listar();
    if (ps.Length == 0) {
      Console.WriteLine("Nenhuma pizza cadastrada");
      return;
    }
    foreach(Pizza p in ps) Console.WriteLine(p);
    Console.WriteLine();
  }
  public static void PizzaInserir() {
    Console.WriteLine("------Inserção de pizzas------");
    Console.Write("Informe um código para a pizza: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe uma descrição: ");
    string descrição = Console.ReadLine();
    Console.Write("Informe a porção da pizza: ");
    int porcao = int.Parse(Console.ReadLine());
    Console.Write("Informe o preço da pizza: ");
    double preco = double.Parse(Console.ReadLine());

    TipoListar();
    Console.Write("Informe o código do tipo de pizza: ");
    int idtipo = int.Parse(Console.ReadLine());
    // Seleciona o tipo a partir do id
    Tipo t = ntipo.Listar(idtipo);
    // Instanciar a classe de Pizza
    Pizza p = new Pizza(id, descrição, porcao, preco, t);
    // Inserção da pizza
    npizza.Inserir(p);
  }
  public static void PizzaAtualizar(){

  }
  public static void PizzaExcluir(){
    
  }
}
