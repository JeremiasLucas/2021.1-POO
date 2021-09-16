using System;

class NTipo {
  private Tipo[] tipos = new Tipo[10];
  private int nt;

  public Tipo[] Listar() {
    Tipo[] t = new Tipo[nt];
    Array.Copy(tipos, t, nt);
    return t;
  }

  public Tipo Listar(int id) {
    for (int i = 0; i < nt; i++)
      if (tipos[i].GetId() == id) return tipos[i];
  return null;
  }
  
  public void Inserir(Tipo t) {
    if (nt == tipos.Length) {
      Array.Resize(ref tipos, 2 * tipos.Length);
    }
    tipos[nt] = t;
    nt++;
  }

  public void Atualizar(Tipo t) {
  // Localisar no vetor o tipo que possui o id informado no parametro tipo
  Tipo t_atual = Listar(t.GetId());
  if(t_atual == null) return;
  // Alterar os dados do meu tipo
  t_atual.SetDescricao(t.GetDescricao());
  }

  private int Indice(Tipo t) {
    for (int i = 0; i < nt; i++)
      if (tipos[i] == t) return i;
    return -1;
  }

  public void Excluir(Tipo t) {
    // Verifica se o tipo está cadastrado
    int n = Indice(t);
    if (n == 1) return;
    for (int i = n; i < nt - 1; i++)
      tipos[i] = tipos[i + 1];
    nt--;
    // Recuperar a lista de pizza do tipo
    Pizza[] ps = t.PizzaListar();
    foreach(Pizza p in ps) p.SetTipos(null);
  }
}
