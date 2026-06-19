using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BibliotecaApp.Servicos
{

    public class AcervoService
    {
        private const string Arquivo = "acervo.json";

        public List<Livros> Acervo { get; private set; }

        public AcervoService()
        {
            Acervo = CarregarAcervo();
        }

        private List<Livros> CarregarAcervo()
        {
            if (!File.Exists(Arquivo))
                return new List<Livros>();

            string json = File.ReadAllText(Arquivo);

            return JsonConvert.DeserializeObject<List<Livros>>(json)
                   ?? new List<Livros>();
        }

        public void SalvarAcervo()
        {
            string json = JsonConvert.SerializeObject(
                Acervo,
                Formatting.Indented);

            File.WriteAllText(Arquivo, json);
        }

        public void AdicionarLivro(Livros livro)
        {
            Acervo.Add(livro);
            SalvarAcervo();
        }
    }
}
