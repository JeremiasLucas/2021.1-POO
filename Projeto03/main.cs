using System;

class MainClass {
  public static void Main() {
    Tipos t1 = new Tipos(1, "Pizzas Salgadas");
    Tipos t2 = new Tipos(2, "Pizzas Doces");
    
    Console.WriteLine(t1);
    Console.WriteLine(t2);

    Pizza p1 = new Pizza(1, "Pizza de atum", 10, 10, t1);
    Pizza p2 = new Pizza(2, "Pizza de frango com catupiry", 15, 15, t1);
    Pizza p3 = new Pizza(3, "Pizza de Chocolate com Morango", 10, 11, t2);
    Pizza p4 = new Pizza(4, "Refrigerante Guaraná", 15, 4);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);

    t1.PizzaInserir(p1);
    t1.PizzaInserir(p2);
    t2.PizzaInserir(p3);

    Pizza[] v = t1.PizzaListar();
    Console.Write("Pizzas na categoria: ");
    Console.WriteLine(t1.GetDescricao());
    foreach (Pizza p in v) Console.WriteLine(p);

    Console.WriteLine();
    v = t2.PizzaListar();
    Console.Write("Pizzas na categoria: ");
    Console.WriteLine(t2.GetDescricao());
    foreach (Pizza p in v) Console.WriteLine(p);
  }
}
