using System;

public class Cliente : IComparable<Cliente> {
  //Propiedades do cliente
  public int Id {get; set; }
  public string Nome {get; set; }
  public DateTime Nascimento {get; set; }
  public int CompareTo(Cliente obj) {
    return this.Nome.CompareTo(obj.Nome);
  }
  public override string ToString() {
    return Id + " - " + Nome + " - " + Nascimento.ToString("dd/MM/yyyy");
  }
}
