using System;

class NPizza {
  private Pizza[] pizzas = new Pizza[10];
  private int np;

  public Pizza[] Listar() {
    Pizza[] p = new Pizza[np];
    Array.Copy(pizzas, p, np);
    return p;
  }

  public Pizza Listar(int id) {
    for (int i = 0; i < np; i++)
      if (pizzas[i].GetId() == id) return pizzas[i];
  return null;
  }
  
  public void Inserir(Pizza p) {
    if (np == pizzas.Length) {
      Array.Resize(ref pizzas, 2 * pizzas.Length);
    }
    pizzas[np] = p;
    np++;
    // Recuperar o tipo de pizza que está sendo inserida
    Tipo t = p.GetTipos();
    if(t != null) t.PizzaInserir(p);
  }
}
