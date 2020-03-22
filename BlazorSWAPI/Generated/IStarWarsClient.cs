using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IStarWarsClient
    {
        Task<IOperationResult<global::BlazorSWAPI.IGetCharacters>> GetCharactersAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BlazorSWAPI.IGetCharacters>> GetCharactersAsync(
            GetCharactersOperation operation,
            CancellationToken cancellationToken = default);
    }
}
