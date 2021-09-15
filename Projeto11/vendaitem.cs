using System;

class VendaItem {
  // Atributos do item de VendaPizza
  private int porcoes;
  private double preco;
  // Associação entre VendaItem e pizza
  private Pizza pizza;
  public VendaItem(int porcoes, Pizza pizza) {
    this.porcoes = porcoes;
    this.preco = pizza.GetPreco();
    this.pizza = pizza;
  }
  public void SetPorcoes(int porcoes) {
    this.porcoes = porcoes;
  }
  public void SetPreco(double preco) {
    this.preco = preco;
  }
  public void SetPizza(Pizza pizza) {
    this.pizza = pizza;
  }
  public int GetPorcoes() {
    return porcoes;
  }
  public double GetPreco() {
    return preco;
  }
  public Pizza GetPizza() {
    return pizza;
  }
  public override string ToString(){
    return pizza.GetDescricao() + " - Porcoes:" + porcoes + "Preco: " + preco.ToString("c2");
  }
}
