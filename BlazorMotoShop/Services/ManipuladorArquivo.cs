namespace BlazorMotoShop.Services
{
    public class ManipuladorArquivo : IManipuladorArquivo
    {
        private readonly IWebHostEnvironment _environment;

        public ManipuladorArquivo(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public bool VerificarNomeArquivoSalvo(string nomeArquivo)
        {
            string diretorioUpload = MontaCaminhoArquivo(nomeArquivo);

            return File.Exists(diretorioUpload);
        }

        public void ExcluiArquivoSalvo(string nomeArquivo)
        {
            string diretorioUpload = MontaCaminhoArquivo(nomeArquivo);

            File.Delete(diretorioUpload);
        }

        private string MontaCaminhoArquivo(string nomeArquivo)
        {
            // Combina o caminho relativo da pasta 'wwwroot' com a pasta criada alvo que será salvo a imagem enviada
            return Path.Combine(_environment.WebRootPath, "uploads", nomeArquivo);
        }
    }
}
