using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CharacterConnection
        : ICharacterConnection
    {
        public CharacterConnection(
            global::System.Collections.Generic.IReadOnlyList<global::BlazorSWAPI.ICharacter> nodes)
        {
            Nodes = nodes;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorSWAPI.ICharacter> Nodes { get; }
    }
}
