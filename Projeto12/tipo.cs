using System;

public class Tipo {
  private int id;
  private string descricao;
  private Pizza[] pizzas = new Pizza[10];
  private int np;
  // Propiedades e construdor necessários para a serialização
  public int Id { get => id; set => id = value; }
  public string Descricao { get => descricao; set => descricao = value; }
  public Tipo() { }

  public Tipo(int id, string descricao) {
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
  public void PizzaInserir(Pizza p) {
    if (np == pizzas.Length) {
      Array.Resize(ref pizzas, 2 * pizzas.Length);
    }
    pizzas[np] = p;
    np++;
  }
  private int PizzaIndice(Pizza p) {
    for(int i = 0; i < np; i++)
      if(pizzas[i] == p) return i;
    return -1;
  }
  public void PizzaExcluir(Pizza p) {
    int n = PizzaIndice(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      pizzas[i] = pizzas[i + 1];
    np--;
  }

  public override string ToString() {
    return id + " - " + descricao + " - N° pizzas: " + np;
  }
}
