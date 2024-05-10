using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract23
{
    public class CodeBuilder
    {
        private StringBuilder builder = new StringBuilder();
        private int indentLevel = 0;
        public CodeBuilder Indent(int count=1)
        {
            indentLevel+=count;
            return this;
        }
        public CodeBuilder TabIndent(int count=1)
        {
            indentLevel+=count*4;
            return this;
        }

        public StringBuilder Append(string value)
        {
            return builder.Append(new string(' ', indentLevel)).Append(value);
        }
        public StringBuilder AppendLine(string value)
        {
            return builder.AppendLine(new string(' ', indentLevel)+value);
        }
        public override string ToString() => builder.ToString();
        // и другие методы класса 
    }

    internal class Program
    {
        static string testString= "public class CodeBuilder\n{\nprivate StringBuilder builder = new StringBuilder();\nprivate int indentLevel = 0;\npublic CodeBuilder Indent(int count = 1)\n{\nindentLevel += count;\nreturn this;\n}\npublic CodeBuilder TabIndent(int count = 1)\n{\nindentLevel += count * 4;\nreturn this;\n}\n\npublic StringBuilder Append(string value)\n{\nreturn builder.Append(new string(' ', indentLevel)).Append(value);\r\n}\r\npublic StringBuilder AppendLine()\n{\nreturn builder.AppendLine();\n}\npublic override string ToString() => builder.ToString();\n// и другие методы класса \n}";

        static void Main(string[] args)
        {
            CodeBuilder codeBuilder = new CodeBuilder();
            codeBuilder.TabIndent();
            codeBuilder.Append("dfgh,lfglglglglglglggl\n");
            codeBuilder.Append("ssus\n");
            codeBuilder.Indent(10);

            string[] strings=testString.Split('\n');
            foreach (string s in strings)
            {
                codeBuilder.AppendLine(s);
            }


            Console.Write(codeBuilder);


            Console.ReadKey(true);
        }
    }
}
