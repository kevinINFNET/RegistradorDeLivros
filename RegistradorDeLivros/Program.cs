namespace RegistroDeLivros
{
 class Program
    {
   public class Livro
     {
  public string Titulo { get; set; }
  public string Autor { get; set; }
  public int AnoPublicacao { get; set; }
  public decimal Preco { get; set; }
   }
   static void Main(string[] args)
        {
    Livro livro = new Livro();

  Action<string, string, int, decimal> registrarLivro = (titulo, autor, ano, preco) =>
 {
   livro.Titulo = titulo;
   livro.Autor = autor;
   livro.AnoPublicacao = ano;
   livro.Preco = preco;
  };
   Action exibirLivro = () =>
            {
  Console.WriteLine("Informações do Livro:");
  Console.WriteLine($"Título: {livro.Titulo}");
  Console.WriteLine($"Autor: {livro.Autor}");
  Console.WriteLine($"Ano de Publicação: {livro.AnoPublicacao}");
  Console.WriteLine($"Preço: R$ {livro.Preco:F2}");
    };
  registrarLivro("Jujutsu Kaisen", "Gege Akutami", 2018, 50.00m);
   exibirLivro();
  Console.ReadLine();
    }
  }
}
