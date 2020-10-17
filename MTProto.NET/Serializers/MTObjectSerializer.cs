using MTProto.NET.Attributes;
using MTProto.NET.Enums;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MTProto.NET.Serializers
{
    public class MTObjectSerializer : ISerializer<MTObject>
    {
        public static MTObject Deserialize(BinaryReader reader)
        {
            uint constructor = reader.ReadUInt32();

            MTObject obj;
            Type t = null;
            try
            {
                t = MTContext.GetType(constructor);
                obj = (MTObject)Activator.CreateInstance(t);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("MTObject deserialization failed: invalid constructor", ex);
            }

            var fieldsToDeserialize =
                obj.GetType().GetProperties()
                        .Where(x => x.GetCustomAttribute<MTParameterAttribute>() != null)
                        .Select(x =>
                        {
                            var attrib = x.GetCustomAttribute<MTParameterAttribute>();
                            return new Field
                            {
                                IsFlag = attrib.IsFlag,
                                FlagType = attrib.FlagType,
                                FlagBitId = attrib.FlagBitId,
                                BigIntegerBytesCount = attrib.BigIntegerBytesCount != -1 ? attrib.BigIntegerBytesCount : (int?)null,
                                Order = attrib.Order,
                                Info = x,
                                Type = x.PropertyType
                            };
                        });

            fieldsToDeserialize.OrderBy(x => x.Order);

            int flags = 0;

            foreach (var field in fieldsToDeserialize)
            {
                var value = SerializationContext.Deserialize(reader, field.Type, field.BigIntegerBytesCount);

                if (field.FlagBitId != -1)
                    if (field.FlagType == FlagType.Null)
                    {
                        if (!IsFlagActive(flags, field.FlagBitId))
                        {
                            field.Info.SetValue(obj, null);
                            continue;
                        }
                    }
                    else if (field.FlagType == FlagType.True)
                    {
                        field.Info.SetValue(obj, IsFlagActive(flags, field.FlagBitId));
                        continue;
                    }

                field.Info.SetValue(obj, value);

                if (field.IsFlag)
                    flags = (int)value;

            }

            return obj;
        }

        public static void Serialize(MTObject data, BinaryWriter writer)
        {
            writer.Write(data.Constructor);

            var fieldsToSerialize =
                data.GetType()
                    .GetProperties()
                    .Where(x => x.GetCustomAttribute<MTParameterAttribute>() != null)
                    .Select(x =>
                    {
                        var attrib = x.GetCustomAttribute<MTParameterAttribute>();
                        return new Field
                        {
                            IsFlag = attrib.IsFlag,
                            FlagType = attrib.FlagType,
                            FlagBitId = attrib.FlagBitId,
                            Order = attrib.Order,
                            Value = x.GetValue(data),
                            Type = x.PropertyType
                        };
                    });
            fieldsToSerialize.OrderBy(x => x.Order);

            foreach (var fieldToSerialize in fieldsToSerialize)
            {
                if (fieldToSerialize.IsFlag)
                    writer.Write(ComputeFlags(data));


                if (fieldToSerialize.FlagBitId != -1)
                {
                    if (fieldToSerialize.FlagType == FlagType.Null &&
                            fieldToSerialize.Value == null)
                        continue;
                    else if (fieldToSerialize.FlagType == FlagType.True)
                        continue;
                }

                SerializationContext.Serialize(
                        writer,
                        fieldToSerialize.Value
                    );

            }
        }

        private static int ComputeFlags(MTObject data)
        {
            var fields = data
                .GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttribute<MTParameterAttribute>() != null &&
                            x.GetCustomAttribute<MTParameterAttribute>().FlagBitId != -1)
                .Select(x =>
                    {
                        var attrib = x.GetCustomAttribute<MTParameterAttribute>();
                        return new FieldToComputeFlag
                        {
                            FlagType = attrib.FlagType,
                            FlagBitId = attrib.FlagBitId,
                            Value = x.GetValue(data)
                        };
                    });

            int flags = 0;

            foreach (var field in fields)
            {
                if (field.FlagType == FlagType.Null)
                {
                    if (field.Value != null)
                    {
                        flags |= GetBitMask(field.FlagBitId); //not null bit should be active
                    }
                    else
                    {
                        flags &= ~GetBitMask(field.FlagBitId); // null bit should be deactive
                    }
                }
                else if (field.FlagType == FlagType.True)
                {
                    if (field.Value is bool value)
                    {
                        flags = value ?
                            (flags | GetBitMask(field.FlagBitId)) : //true bit should be active
                            (flags & ~GetBitMask(field.FlagBitId)); //false bit should be deactive
                    }
                    else throw new InvalidOperationException();
                }
            }

            return flags;
        }

        private static int GetBitMask(int number)
        {
            return (int)Math.Pow(2, number);
        }
        private static bool IsFlagActive(int flags, int number) => (flags & GetBitMask(number)) != 0;

        private class FieldToComputeFlag
        {

            public int FlagBitId { get; set; }
            public FlagType FlagType { get; set; }
            public object Value { get; set; }
        }
        private class Field
        {
            public int Order { get; set; }
            public bool IsFlag { get; set; }
            public int FlagBitId { get; set; }
            public FlagType FlagType { get; set; }
            public object Value { get; set; }
            public Type Type { get; set; }
            public PropertyInfo Info { get; internal set; }
            public int? BigIntegerBytesCount { get; internal set; }
        }
    }
}
