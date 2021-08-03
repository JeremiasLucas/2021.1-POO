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
}
