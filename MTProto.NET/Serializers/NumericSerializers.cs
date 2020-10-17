using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class Int32Serializer : ISerializer<int>
    {
        public static int Deserialize(BinaryReader reader) =>
            reader.ReadInt32();

        public static void Serialize(int data, BinaryWriter writer) =>
            writer.Write(data);
    }
    public class Int64Serializer : ISerializer<long>
    {
        public static long Deserialize(BinaryReader reader) =>
            reader.ReadInt64();

        public static void Serialize(long data, BinaryWriter writer) =>
            writer.Write(data);
    }
    public class UInt32Serializer : ISerializer<uint>
    {
        public static uint Deserialize(BinaryReader reader) =>
            reader.ReadUInt32();

        public static void Serialize(uint data, BinaryWriter writer) =>
            writer.Write(data);
    }
    public class DoubleSerializer : ISerializer<double>
    {
        public static double Deserialize(BinaryReader reader) =>
            reader.ReadDouble();

        public static void Serialize(double data, BinaryWriter writer) =>
            writer.Write(data);
    }
}
