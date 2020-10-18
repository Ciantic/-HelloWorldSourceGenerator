using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

// Bits of code originally from http://dontcodetired.com/blog/post/C-Source-Generators-Less-Boilerplate-Code-More-Productivity

namespace MyGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            const string source = @"
                namespace MyGeneratedNamespace
                {
                    public class MyGeneratedClass
                    {
                        public string HelloWorld() {
                            return ""Hello World"";
                        }
                    }
                }
                ";
            const string desiredFileName = "HelloWorld.cs";
            SourceText sourceText = SourceText.From(source, Encoding.UTF8);
            context.AddSource(desiredFileName, sourceText);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // throw new NotImplementedException();
        }
    }
}