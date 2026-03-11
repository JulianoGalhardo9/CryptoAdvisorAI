using CryptoAdvisorAI.Application.Interfaces;

namespace CryptoAdvisorAI.Application.UseCases
{
    public class GenerateAdviceUseCase
    {
        private readonly IGetPortfolioUseCase _getPortfolioUseCase;
        private readonly ICryptoAdvisorService _advisorService;

        public GenerateAdviceUseCase(
            IGetPortfolioUseCase getPortfolioUseCase,
            ICryptoAdvisorService advisorService)
        {
            _getPortfolioUseCase = getPortfolioUseCase;
            _advisorService = advisorService;
        }

        public async Task<string> ExecuteAsync()
        {
            // 1. Pega os dados atuais da carteira
            var portfolio = await _getPortfolioUseCase.ExecuteAsync();

            // 2. Passa para a IA analisar
            return await _advisorService.GetAdviceAsync(portfolio);
        }
    }
}

