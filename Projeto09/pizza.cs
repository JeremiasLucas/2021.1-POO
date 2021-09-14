using System;

class Pizza {
  private int id;
  private string descricao;
  private int porcoes;
  private double preco;
  private Tipo tipos;

  public Pizza(int id, string descricao, int porcoes, double preco) {
    this.id = id;
    this.descricao = descricao;
    this.porcoes = porcoes > 0 ? porcoes : 0;
    this.preco = preco > 0 ? porcoes : 0;
  }
  public Pizza(int id, string descricao, int porcoes, double preco, Tipo tipos) : this(id, descricao, porcoes, preco) {
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
  public void SetTipos(Tipo tipos) {
    this.tipos = tipos;
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
  public Tipo GetTipos() {
    return tipos;
  }
  public override string ToString() {
    if (tipos == null)
      return id + " - " + descricao + " - porcoes: " + porcoes + " - preco: " + preco.ToString("0.00");
    else
      return id + " - " + descricao + " - porcoes: " + porcoes + " - preco: " + preco.ToString("0.00") + " - " + tipos.GetDescricao();
  }
}
