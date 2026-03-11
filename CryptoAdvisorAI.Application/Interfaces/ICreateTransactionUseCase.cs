using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Domain.Entities;

namespace CryptoAdvisorAI.Application.Interfaces
{
    public interface ICreateTransactionUseCase
    {
        // O contrato diz: "Eu recebo um pedido (DTO) e devolvo a transação criada"
        Task<Transaction> ExecuteAsync(CreateTransactionRequest request);
    }
}

