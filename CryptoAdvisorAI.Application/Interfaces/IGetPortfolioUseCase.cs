using CryptoAdvisorAI.Application.DTOs;

namespace CryptoAdvisorAI.Application.Interfaces
{
    public interface IGetPortfolioUseCase
    {
        Task<PortfolioResponse> ExecuteAsync();
    }
}

