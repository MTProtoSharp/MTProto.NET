using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MTSharp.Serializers
{
    public static class SerializationContext
    {
        static SerializationContext()
        {
            Serializers = (from t in Assembly.GetExecutingAssembly().GetTypes()
                           where t.IsClass && !t.IsAbstract && t.Namespace != null && t.Namespace.StartsWith(typeof(SerializationContext).Namespace)
                           where IsSubclassOfRawGeneric(typeof(ISerializer<>), t)
                           select t).ToDictionary(x =>
                           x.BaseType.GenericTypeArguments.First()
                           , x => x);
        }

        private static Dictionary<Type, Type> Serializers { get; }

        public static object Deserialize(byte[] data, Type type = null)
        {
            return Deserialize(data, type, null);
        }

        public static object Deserialize(BinaryReader reader, Type type = null)
        {
            return Deserialize(reader, type, null);
        }

        internal static object Deserialize(byte[] data, Type type = null, object arg1 = null)
        {
            using MemoryStream memoryStream = new MemoryStream(data);
            using BinaryReader reader = new BinaryReader(memoryStream);
            return Deserialize(reader, type, arg1);
        }

        internal static object Deserialize(BinaryReader reader, Type type = null, object arg1 = null)
        {
            var args = new List<object> { reader };
            if (arg1 != null) args.Add(arg1);

            type ??= typeof(MTObject);

            if (!type.IsGenericType)
            {
                var serializerType = Serializers[type];
                return serializerType.InvokeMember("Deserialize", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, args.ToArray());
            }
            else
            {
                var serializerType = Serializers.First(x => x.Key.Name == type.GetGenericTypeDefinition().Name).Value;
                serializerType = serializerType.MakeGenericType(type.GenericTypeArguments);
                return serializerType.InvokeMember("Deserialize", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, new object[] { reader });
            }
        }

        public static byte[] Serialize(object value)
        {
            using MemoryStream memoryStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(memoryStream);
            Serialize(writer, value);
            return memoryStream.ToArray();
        }

        public static void Serialize(BinaryWriter writer, object value)
        {
            var type = value.GetType();

            if (type.BaseType == typeof(MTObject))
            {
                type = type.BaseType;
                var serializerType = Serializers[type];
                serializerType.InvokeMember("Serialize", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, new object[] { value, writer });
            }
            else if (!type.IsGenericType)
            {
                var serializerType = Serializers[type];
                serializerType.InvokeMember("Serialize", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, new object[] { value, writer });
            }
            else
            {
                var serializerType = Serializers[type.GetGenericTypeDefinition()];
                serializerType = serializerType.MakeGenericType(type.GenericTypeArguments);
                serializerType.InvokeMember("Serialize", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, new object[] { value, writer });
            }
        }

        private static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

    }
}
