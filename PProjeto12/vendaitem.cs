using System;

public class VendaItem {
  // Atributos do item de VendaPizza
  private int porcoes;
  private double preco;
  // Associação entre VendaItem e pizza
  private Pizza pizza;
  private int pizzaId;

  // Propriedades do item de venda
  public int Porcoes { get => porcoes; set => porcoes = value; }
  public double Preco { get => preco; set => preco = value; }
  public int PizzaId { get => pizzaId; set => pizzaId = value; }
  public VendaItem() { }

  public VendaItem(int porcoes, Pizza pizza) {
    this.porcoes = porcoes;
    this.preco = pizza.GetPreco();
    this.pizza = pizza;
    this.pizzaId = pizza.GetId();
  }
  public void SetPorcoes(int porcoes) {
    this.porcoes = porcoes;
  }
  public void SetPreco(double preco) {
    this.preco = preco;
  }
  public void SetPizza(Pizza pizza) {
    this.pizza = pizza;
    this.pizzaId = pizza.GetId();
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
    return pizza.GetDescricao() + " - Porcoes: " + porcoes + " - Preco: " + preco.ToString("c2");
  }
}
