using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class BoolSerializer : ISerializer<bool>
    {

        private const uint FALSE_CONSTRUCTOR = 0xbc799737;
        private const uint TRUE_CONSTRUCTOR = 0x997275b5;

        public static bool Deserialize(BinaryReader reader)
        {
            uint constructor = reader.ReadUInt32();
            switch (constructor)
            {
                case FALSE_CONSTRUCTOR:
                    return false;
                case TRUE_CONSTRUCTOR:
                    return true;
                default:
                    throw new InvalidDataException($"Bool deserialization failed: unknown constructor {constructor}");
            }
        }

        public static void Serialize(bool src, BinaryWriter writer)
        {
            switch (src)
            {
                case false:
                    writer.Write(FALSE_CONSTRUCTOR);
                    break;
                case true:
                    writer.Write(TRUE_CONSTRUCTOR);
                    break;
            }
        }
    }
}
