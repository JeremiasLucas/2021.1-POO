using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;

class NPizza {
  private NPizza() { }
  static NPizza obj = new NPizza();
  public static NPizza Singleton { get => obj; }

  private Pizza[] pizzas = new Pizza[10];
  private int np;

  public void Abrir() {
    Arquivo<Pizza[]> f = new Arquivo<Pizza[]>();
    pizzas= f.Abrir("./pizzas.xml");
    np = pizzas.Length;
    AtualizarTipo();


    //XmlSerializer xml = new XmlSerializer(typeof(Pizza[]));
    //StreamReader f = new StreamReader("./pizzas.xml", Encoding.Default);
    //pizzas = (Pizza[]) xml.Deserialize(f);
    //f.Close();
    //np = pizzas.Length;
    //AtualizarTipo();
  }

  private void AtualizarTipo() {
    // Pecorrer o vetor de pizzas para atualizar o tipo da pizza
    for(int i = 0; i < np; i++) {
      // Cada pizza no vetor
      Pizza p = pizzas[i];
      // Recuperar o tipo
      Tipo t = NTipo.Singleton.Listar(p.TipoId);
      // Associação entre pizza e tipo
      if (t != null) {
        p.SetTipos(t);
        t.PizzaInserir(p);
      }
    }
  }



  public void Salvar() {
    Arquivo<Pizza[]> f = new Arquivo<Pizza[]>();
    f.Salvar("./pizzas.xml", Listar());
    
    //XmlSerializer xml = new XmlSerializer(typeof(Pizza[]));
    //StreamWriter f = new StreamWriter("./pizzass.xml", false, Encoding.Default);
    //xml.Serialize(f, Listar());
    //f.Close();
  }



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
    if (t != null) t.PizzaInserir(p);
  }

  public void Atualizar(Pizza p) {
    // Atualização dos dados de uma pizza
    // p - id - demais atributos - novos dados dessa pizza
    Pizza p_atual = Listar(p.GetId());
    // Alterar os demais atributos da pizza
    p_atual.SetDescricao(p.GetDescricao());
    p_atual.SetPorcoes(p.GetPorcoes());
    p_atual.SetPreco(p.GetPreco());
    // Excluir a pizza do tipo atual
    if (p_atual.GetTipos() != null) {
      p_atual.GetTipos().PizzaExcluir(p_atual);
    }
    // Atualizar o tipo da pizza
    p_atual.SetTipos(p.GetTipos());
    // Inserir a pizza no novo tipo
    if (p_atual.GetTipos() != null)
      p_atual.GetTipos().PizzaInserir(p_atual);
  }

  private int Indice(Pizza p) {
    for(int i = 0; i < np; i++)
      if(pizzas[i] == p) return i;
    return -1;
  }

  public void Excluir(Pizza p) {
    // Verificar se a pizza existe
    int n = Indice(p);
    if (n == -1) return;
    // Remove a pizza do vetor
    for (int i = n; i < np - 1; i++)
      pizzas[i] = pizzas[i + 1];
    np--;
    // Remove a pizza de seu tipo
    Tipo t = p.GetTipos();
    if (t != null) t.PizzaExcluir(p);
  }
}
