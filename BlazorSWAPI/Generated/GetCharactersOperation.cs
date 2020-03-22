using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCharactersOperation
        : IOperation<IGetCharacters>
    {
        public string Name => "getCharacters";

        public IDocument Document => Query.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetCharacters);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
