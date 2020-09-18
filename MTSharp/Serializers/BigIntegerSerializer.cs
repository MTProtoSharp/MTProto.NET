using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTSharp.Serializers
{
    public class BigIntegerSerializer : ISerializer<BigInteger>
    {
        public static BigInteger Deserialize(BinaryReader reader, int arg1)
        {
            return new BigInteger(1, reader.ReadBytes(arg1));
        }

        public static void Serialize(BigInteger data, BinaryWriter writer) =>
            writer.Write(data.ToByteArrayUnsigned());
    }
}
