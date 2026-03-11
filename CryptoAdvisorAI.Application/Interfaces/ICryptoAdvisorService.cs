using CryptoAdvisorAI.Application.DTOs;

namespace CryptoAdvisorAI.Application.Interfaces
{
    public interface ICryptoAdvisorService
    {
        // O contrato diz: "Eu recebo o seu portfólio e te devolvo um texto com conselhos"
        Task<string> GetAdviceAsync(PortfolioResponse portfolio);
    }
}

