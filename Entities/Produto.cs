using System;

public class Produto
{
    private string _nome;
    public string Nome
    {
        get { return _nome; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("O nome do produto deve ter no mínimo 3 caracteres.");
            }
            _nome = value;
        }
    }

    public decimal Preco { get; private set; }

    public Produto(string nome, decimal preco)
    {
        // Usando o setter privado aqui
        Nome = nome;
        Preco = preco;
    }
}