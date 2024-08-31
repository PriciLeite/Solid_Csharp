<img src="https://github.com/user-attachments/assets/4d8389fe-9073-4993-93d7-4bff952d2795" alt="Imagem principios solid" style="border-radius: 100px; width: 700px; height:300px;">

# 🔖 Estudos dos Princípios SOLID

Este repositório contém meus estudos sobre os princípios SOLID, abordando desde os conceitos básicos até a aplicação prática dos princípios.

## 💡Conceitos Fundamentais

### 🚦Classe
Uma classe é um molde para a criação de objetos. Ela define um conjunto de atributos e comportamentos que os objetos criados a partir dela irão possuir.

### 🚦Objeto
Um objeto é uma instância de uma classe. Ele representa uma entidade no mundo real com características (atributos) e ações (comportamentos).

### 🚦Atributos
Atributos são as variáveis que armazenam os estados de um objeto. Eles são definidos dentro da classe e determinam as propriedades que um objeto pode ter.

### 🚦Comportamento
Comportamento refere-se aos métodos que definem as ações que um objeto pode realizar. Eles são implementados dentro da classe e manipulam os atributos para modificar o estado do objeto.

### 💡Elementos da Classe
Dentro de uma classe, podemos listar e definir os seguintes elementos:
- **Campos**: Variáveis que armazenam dados.
- **Propriedades**: Métodos de acesso que permitem a leitura e escrita dos campos.
- **Métodos**: Funções que definem o comportamento dos objetos.
- **Construtores**: Métodos especiais usados para inicializar os objetos.

## 💡Sobrecarga de Construtores

A sobrecarga de construtores permite que uma classe tenha mais de um construtor, cada um com diferentes parâmetros. Isso oferece flexibilidade na criação de objetos.

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, int idade) : this(nome)
    {
        Idade = idade;
    }
}
```

No exemplo acima, o construtor que recebe `nome` chama o segundo construtor utilizando o `this`, permitindo a reutilização do código.

## 💡Modificadores de Acesso

### 🚦Public
Disponível em qualquer lugar, dentro ou fora do assembly.

### 🚦Internal
Disponível apenas dentro do mesmo assembly.

### 🚦Private
Disponível apenas dentro da classe onde foi declarado.

### 🚦Private protected
Disponível dentro da classe ou em classes derivadas dentro do mesmo assembly.

### 💡Modificadores Padrões
- **✔️ Classes**: `internal`
- **✔️ Campos**: `private`
- **✔️ Propriedades**: `private`
- **✔️ Métodos**: `private`

## 💫Em andamento...

Este repositório será atualizado à medida que avanço nos estudos dos princípios SOLID e sua aplicação em diferentes cenários.

