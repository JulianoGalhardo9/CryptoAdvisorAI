using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Domain.Entities;
using CryptoAdvisorAI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CryptoAdvisorAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // O endereço será: api/transactions
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionRepository _repository;

        // Injeção de Dependência: Pedimos o Repositório para o .NET
        public TransactionsController(ITransactionRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTransactionRequest request)
        {
            //Transformamos o DTO na Entidade (regras de negócio)
            var transaction = new Transaction(
                request.Symbol,
                request.Quantity,
                request.PriceAtPurchase,
                request.PurchaseDate
            );

            // repositório salvar no Postgres
            await _repository.AddAsync(transaction);

            //Respondemos "200 OK" com a transação criada
            return Ok(transaction);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _repository.GetAllAsync();
            return Ok(transactions);
        }
    }
}

