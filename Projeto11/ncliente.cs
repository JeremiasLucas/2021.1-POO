using System;
using System.Collections.Generic;

class NCliente {
  private List<Cliente> clientes = new List<Cliente>();

  public List<Cliente> Listar() {
    // Retorna uma lista com os clientes cadastrados
    clientes.Sort();
    return clientes;
  }

  public Cliente Listar(int id) {
    // Localisar na lista o cliente com o id informado
    for (int i = 0; i < clientes.Count; i++)
      if (clientes[i].Id == id) return clientes[i];
  return null;
  }
  
  public void Inserir(Cliente c) {
    // Gera o id do cliente
    int max = 0;
    foreach(Cliente obj in clientes)
      if (obj.Id > max) max = obj.Id;
    c.Id = max + 1;
    // Inseri o cliente na lista
    clientes.Add(c);
  }

  public void Atualizar(Cliente c) {
  // Localisar na lista o cliente que possui o id informado no parametro tipo
  Cliente c_atual = Listar(c.Id);
  // Se não encontrar o cliente com o id, retorna sem alterar
  if(c_atual == null) return;
  // Alterar os dados do cliente
  c_atual.Nome = c.Nome;
  c_atual.Nascimento = c.Nascimento;
  }

  public void Excluir(Cliente c) {
    // Remove o cliente da lista
    if (c != null) clientes.Remove(c);
  }
}
