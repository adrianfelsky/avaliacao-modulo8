using System;

public class Livros
{
    private int _id;
    private string _titulo;
    private string _autor;
    private int _ano;
    private bool _disponivel;

    public int ID
    {
        get { return _id; }
        private set { _id = value; }
    }
    public string Titulo
    {
        get { return _titulo; }
        private set { _titulo = value; }
    }
    public string Autor
    {
        get { return _autor; }
        private set { _autor = value; }
    }
    public int Ano
    {
        get { return _ano; }
        private set { _ano = value; }
    }
    public bool Disponivel
    {
        get { return _disponivel; }
        private set { _disponivel = value; }
    }

    public Livros (int id, string titulo,  string autor, int ano, bool disponivel)
    {
        ID = id;
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Disponivel = disponivel;
    }
}
}
