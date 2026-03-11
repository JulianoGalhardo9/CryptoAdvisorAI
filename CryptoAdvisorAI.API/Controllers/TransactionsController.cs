using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Domain.Entities;
using CryptoAdvisorAI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CryptoAdvisorAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // O endereço será: api/transactions
    public class TransactionsController : ControllerBase
    {
        private readonly ICreateTransactionUseCase _createTransactionUseCase;
        private readonly ITransactionRepository _repository;

        // Injeção de Dependência: Pedimos o Repositório para o .NET
        public TransactionsController(
            ICreateTransactionUseCase createTransactionUseCase,
            ITransactionRepository repository)
        {
            _createTransactionUseCase = createTransactionUseCase;
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTransactionRequest request)
        {
            // A Controller agora só "manda" o UseCase executar
            var result = await _createTransactionUseCase.ExecuteAsync(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _repository.GetAllAsync();
            return Ok(transactions);
        }
    }
}

