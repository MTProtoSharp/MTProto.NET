using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class StringSerializer : ISerializer<string>
    {
        public static string Deserialize(BinaryReader reader)
        {
            byte[] srcBytes = BytesSerializer.Deserialize(reader);
            return Encoding.UTF8.GetString(srcBytes);
        }

        public static void Serialize(string data, BinaryWriter writer) =>
            BytesSerializer.Serialize(Encoding.UTF8.GetBytes(data), writer);
    }
}
