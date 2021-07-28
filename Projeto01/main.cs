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

class Tipos {
  private int id;
  private string descricao;
  public Tipos(int id, string descricao) {
    this.id = id;
    this.descricao = descricao;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetDescricao(string descricao) {
    this.descricao = descricao;
  }
  public int GetId() {
    return id;
  }
  public string GetDescricao() {
    return descricao;
  }
  public override string ToString() {
    return id + " - " + descricao;
  }
}

class Pizza {
  private int id;
  private string descricao;
  private int porcoes;
  private double preco;
  private Tipos tipos;

  public Pizza(int id, string descricao, int porcoes, double preco) {
    this.id = id;
    this.descricao = descricao;
    this.porcoes = porcoes > 0 ? porcoes : 0;
    this.preco = preco > 0 ? porcoes : 0;
  }
  public Pizza(int id, string descricao, int porcoes, double preco, Tipos tipos) : this(id, descricao, porcoes, preco) {
    this.tipos = tipos;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetDescricao(string descricao) {
    this.descricao = descricao;
  }
  public void SetPorcoes(int porcoes) {
    this.porcoes = porcoes > 0 ? porcoes : 0;
  }
  public void SetPreco(double preco) {
    this.preco = preco > 0 ? porcoes : 0;
  }
  public int GetId() {
    return id;
  }
  public string GetDescricao() {
    return descricao;
  }
  public int GetPorcoes() {
    return porcoes;
  }
  public double GetPreco() {
    return preco;
  }
  public override string ToString() {
    if (tipos == null)
      return id + " - " + descricao + " - porcoes: " + porcoes + " - preco: " + preco.ToString("0.00");
    else
      return id + " - " + descricao + " - porcoes: " + porcoes + " - preco: " + preco.ToString("0.00") + " - " + tipos.GetDescricao();
  }
}

