using BlazorMotoShop.Models.Enums;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorMotoShop.Services
{
    public interface IUploadService
    {
        Task<(RetornoStatusUploadArquivo, string)> ArquivoUploadAsync(IBrowserFile arquivo, int tamanhoMaximoPermitido, string[] extensoesPermitidas);
    }
}