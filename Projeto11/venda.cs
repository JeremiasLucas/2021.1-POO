using System;
using System.Collections.Generic;

class Venda {
  // Atributos da venda
  private int id;
  private DateTime data;
  private bool carrinho;
  // Associação entre venda e cliente
  private Cliente cliente;
  // Associação entre venda e itens de venda
  private List<VendaItem> itens = new List<VendaItem>();

  public Venda(DateTime data, Cliente cliente) {
    this.data = data;
    this.carrinho = true;
    this.cliente = cliente;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetData(DateTime data) {
    this.data = data;
  }
  public void SetCarrinho(bool carrinho) {
    this.carrinho = carrinho;
  }
  public void SetCliente(Cliente cliente) {
    this.cliente = cliente;
  }
  public int GetId() {
    return id;
  }
  public DateTime GetData() {
    return data;
  }
  public bool GetCarrinho() {
    return carrinho;
  }
  public Cliente GetCliente() {
    return cliente;
  }
  public override string ToString(){
    if (carrinho)
      return "Compra: " + id + " - " + data.ToString("dd/mm/yyyy") + " - Cliente: " + cliente.Nome + " - carrinho";
    else
      return "Compra: " + id + " - " + data.ToString("dd/mm/yyyy") + " - Cliente: " + cliente.Nome;
    
  }

  private VendaItem ItemListar(Pizza p) {
    // Verificar se a pizza p já está na lista de pizzas
    foreach(VendaItem vi in itens)
      if (vi.GetPizza() == p) return vi;
    return null;
  }

  public List<VendaItem> ItemListar() {
    // Retornar a lista de itens
    return itens;
  }
  public void ItemInserir(int porcao, Pizza p) {
    // Verificar se a pizza p já está na lista de itens
    VendaItem item = ItemListar(p);
    if (item == null) {
      item = new VendaItem(porcao, p);
      itens.Add(item);
    }
    else
      item.SetPorcoes(item.GetPorcoes() + porcao);
  }
  public void ItemExcluir() {
    // Remove todos os itens da lista
    itens.Clear();
  }

}
