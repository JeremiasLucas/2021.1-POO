using System;

public class Pizza {
  // Atributos da pizza
  private int id;
  private string descricao;
  private int porcoes;
  private double preco;
  private int tipoId;
  // Categoria da pizza - Associação entre tipo e pizza
  private Tipo tipos;

  // Propiedades da pizza
  public int Id { get => id; set => id = value; }
  public string Descricao { get => descricao; set => descricao = value; }
  public int Porcoes { get => porcoes; set => porcoes = value; }
  public double Preco { get => preco; set => preco = value; }
  public int TipoId { get => tipoId; set => tipoId = value; }

  public Pizza() { }

  public Pizza(int id, string descricao, int porcoes, double preco) {
    this.id = id;
    this.descricao = descricao;
    this.porcoes = porcoes > 0 ? porcoes : 0;
    this.preco = preco > 0 ? porcoes : 0;
  }
  public Pizza(int id, string descricao, int porcoes, double preco, Tipo tipos) : this(id, descricao, porcoes, preco) {
    this.tipos = tipos;
    this.tipoId = tipos.GetId();
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
    this.tipoId = tipos.GetId();
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
