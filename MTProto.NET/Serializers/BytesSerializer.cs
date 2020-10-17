using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class BytesSerializer : ISerializer<byte[]>
    {
        public static byte[] Deserialize(BinaryReader reader) 
        {
            byte lengthByte = reader.ReadByte();
            int length = -1, padding = -1;

            //If Length >= 254, the serialization contains byte 254
            if (lengthByte == 254)
            {
                // followed by 3 bytes with the string length L
                length =
                    reader.ReadByte() |
                    (reader.ReadByte() << 8) |
                    (reader.ReadByte() << 16);

                padding = length % 4;
            }
            else // If L <= 253, the serialization contains one byte with the value of L
            {
                length = lengthByte;
                padding = (length + 1) % 4;
            }

            byte[] data = reader.ReadBytes(length);

            if (padding > 0)
            {
                padding = 4 - padding;
                reader.ReadBytes(padding);
            }
            

            return data;
        }

        public static void Serialize(byte[] data, BinaryWriter writer)
        {
            int padding;

            if (data.Length <= 253)
            {
                var len = data.Length + 1;
                padding = len % 4 != 0 ? 4 - (len % 4) : 0;

                writer.Write((byte)data.Length);
                writer.Write(data);
            }
            else
            {
                padding = (data.Length % 4) != 0 ? 4 - (data.Length % 4) : 0;

                writer.Write((byte)254);
                writer.Write((byte)data.Length);
                writer.Write((byte)(data.Length >> 8));
                writer.Write((byte)(data.Length >> 16));
                writer.Write(data);
            }

            for (int i = 0; i < padding; i++)
            {
                writer.Write((byte)0);
            }
        }
    }
}
