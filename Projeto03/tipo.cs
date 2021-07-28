using System;

class Tipos {
  private int id;
  private string descricao;
  private Pizza[] pizzas = new Pizza[10];
  private int np;
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
  public Pizza[] PizzaListar() {
    Pizza[] t = new Pizza[np];
    Array.Copy(pizzas, t, np);
    return t;
  }
  public void PizzaInserir(Pizza p){
    if (np == pizzas.Length) {
      Array.Resize(ref pizzas, 2 * pizzas.Length);
    }
    pizzas[np] = p;
    np++;
  }
  public override string ToString() {
    return id + " - " + descricao + " - N° pizzas: " + np;
  }
}
