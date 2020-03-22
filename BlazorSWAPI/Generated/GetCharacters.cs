using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCharacters
        : IGetCharacters
    {
        public GetCharacters(
            global::BlazorSWAPI.ICharacterConnection characters)
        {
            Characters = characters;
        }

        public global::BlazorSWAPI.ICharacterConnection Characters { get; }
    }
}
