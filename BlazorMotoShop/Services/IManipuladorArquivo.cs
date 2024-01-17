namespace BlazorMotoShop.Services
{
    public interface IManipuladorArquivo
    {
        bool VerificarNomeArquivoSalvo(string nomeArquivo);

        void ExcluiArquivoSalvo(string nomeArquivo);
    }
}