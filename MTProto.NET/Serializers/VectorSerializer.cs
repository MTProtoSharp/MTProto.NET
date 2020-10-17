using MTProto.NET.Schema.TL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class VectorSerializer<T> : ISerializer<TLVector<T>>
    {
        public static TLVector<T> Deserialize(BinaryReader reader)
        {
            TLVector<T> vector = new TLVector<T>();

            uint constructor = reader.ReadUInt32();
            if (constructor != vector.Constructor) throw new InvalidOperationException("Vector deserialization failed, this is not a vector!");

            int count = reader.ReadInt32();

            for (int i = 0; i < count; i++)
            {
                vector.Add((T)SerializationContext.Deserialize(reader, typeof(T)));
            }

            return vector;
        }

        public static void Serialize(TLVector<T> vector, BinaryWriter writer)
        {
            writer.Write(vector.Constructor);
            writer.Write(vector.Count);

            foreach (var item in vector)
            {
                SerializationContext.Serialize(writer, item);
            }
        }
    }
}
