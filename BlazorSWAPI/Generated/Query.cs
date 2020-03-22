using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Query
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            98,
            70,
            43,
            113,
            108,
            67,
            56,
            67,
            78,
            77,
            89,
            111,
            80,
            104,
            48,
            68,
            80,
            85,
            73,
            85,
            65,
            81,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            67,
            104,
            97,
            114,
            97,
            99,
            116,
            101,
            114,
            115,
            32,
            123,
            32,
            99,
            104,
            97,
            114,
            97,
            99,
            116,
            101,
            114,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            111,
            100,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            104,
            101,
            105,
            103,
            104,
            116,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Query Default { get; } = new Query();

        public override string ToString() => 
            @"query getCharacters {
              characters {
                nodes {
                  name
                  height
                }
              }
            }";
    }
}
