using System;
using YamlDotNet.Serialization;
namespace AutoMapperTalkDecember2018
{
    public static class ObjectExtentions
    {
        public static void DumpToConsole(this object obj)
        {
            var objName = obj.GetType().Name;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(objName);
            Console.WriteLine(new string('=', objName.Length));

            Console.ResetColor();

            var serializer = new SerializerBuilder().Build();
            var yaml = serializer.Serialize(obj);
            Console.WriteLine(yaml);
            Console.ReadLine();

        }
    }
}
