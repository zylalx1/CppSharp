#pragma once

#include "CppSharp.h"
#include <CppParser.h>

namespace CppSharp
{
    enum struct CppAbi;
    enum struct ParserDiagnosticLevel;
    enum struct ParserResultKind;
    enum struct SourceLocationKind;
    ref class ClangParser;
    ref class Library;
    ref class ParserDiagnostic;
    ref class ParserOptions;
    ref class ParserResult;

    namespace Parser
    {
        enum struct CppAbi;
        enum struct ParserDiagnosticLevel;
        enum struct ParserResultKind;
        ref class ClangParser;
        ref class Library;
        ref class ParserDiagnostic;
        ref class ParserOptions;
        ref class ParserResult;

        public enum struct ParserDiagnosticLevel
        {
            Ignored = 0,
            Note = 1,
            Warning = 2,
            Error = 3,
            Fatal = 4
        };

        public enum struct ParserResultKind
        {
            Success = 0,
            Error = 1,
            FileNotFound = 2
        };

        public enum struct SourceLocationKind
        {
            Invalid = 0,
            Builtin = 1,
            CommandLine = 2,
            System = 3,
            User = 4
        };

        public ref class ParserOptions : ICppInstance
        {
        public:

            property ::CppSharp::CppParser::ParserOptions* NativePtr;
            property System::IntPtr Instance
            {
                virtual System::IntPtr get();
                virtual void set(System::IntPtr instance);
            }

            ParserOptions(::CppSharp::CppParser::ParserOptions* native);
            ParserOptions(System::IntPtr native);
            ParserOptions();

            property System::Collections::Generic::List<System::String^>^ IncludeDirs
            {
                System::Collections::Generic::List<System::String^>^ get();
                void set(System::Collections::Generic::List<System::String^>^);
            }
            property System::Collections::Generic::List<System::String^>^ SystemIncludeDirs
            {
                System::Collections::Generic::List<System::String^>^ get();
                void set(System::Collections::Generic::List<System::String^>^);
            }
            property System::Collections::Generic::List<System::String^>^ Defines
            {
                System::Collections::Generic::List<System::String^>^ get();
                void set(System::Collections::Generic::List<System::String^>^);
            }
            property System::Collections::Generic::List<System::String^>^ LibraryDirs
            {
                System::Collections::Generic::List<System::String^>^ get();
                void set(System::Collections::Generic::List<System::String^>^);
            }
            property System::String^ FileName
            {
                System::String^ get();
                void set(System::String^);
            }
            property CppSharp::Parser::Library^ Library
            {
                CppSharp::Parser::Library^ get();
                void set(CppSharp::Parser::Library^);
            }
            property int ToolSetToUse
            {
                int get();
                void set(int);
            }
            property System::String^ TargetTriple
            {
                System::String^ get();
                void set(System::String^);
            }
            property bool NoStandardIncludes
            {
                bool get();
                void set(bool);
            }
            property bool NoBuiltinIncludes
            {
                bool get();
                void set(bool);
            }
            property bool MicrosoftMode
            {
                bool get();
                void set(bool);
            }
            property CppSharp::Parser::CppAbi Abi
            {
                CppSharp::Parser::CppAbi get();
                void set(CppSharp::Parser::CppAbi);
            }
            property bool Verbose
            {
                bool get();
                void set(bool);
            }
        };

        public ref class ParserDiagnostic : ICppInstance
        {
        public:

            property ::CppSharp::CppParser::ParserDiagnostic* NativePtr;
            property System::IntPtr Instance
            {
                virtual System::IntPtr get();
                virtual void set(System::IntPtr instance);
            }

            ParserDiagnostic(::CppSharp::CppParser::ParserDiagnostic* native);
            ParserDiagnostic(System::IntPtr native);
            ParserDiagnostic();

            property System::String^ FileName
            {
                System::String^ get();
                void set(System::String^);
            }
            property System::String^ Message
            {
                System::String^ get();
                void set(System::String^);
            }
            property CppSharp::Parser::ParserDiagnosticLevel Level
            {
                CppSharp::Parser::ParserDiagnosticLevel get();
                void set(CppSharp::Parser::ParserDiagnosticLevel);
            }
            property int LineNumber
            {
                int get();
                void set(int);
            }
            property int ColumnNumber
            {
                int get();
                void set(int);
            }
        };

        public ref class ParserResult : ICppInstance
        {
        public:

            property ::CppSharp::CppParser::ParserResult* NativePtr;
            property System::IntPtr Instance
            {
                virtual System::IntPtr get();
                virtual void set(System::IntPtr instance);
            }

            ParserResult(::CppSharp::CppParser::ParserResult* native);
            ParserResult(System::IntPtr native);
            ParserResult();

            property CppSharp::Parser::ParserResultKind Kind
            {
                CppSharp::Parser::ParserResultKind get();
                void set(CppSharp::Parser::ParserResultKind);
            }
            property CppSharp::Parser::Library^ Library
            {
                CppSharp::Parser::Library^ get();
                void set(CppSharp::Parser::Library^);
            }
            property System::Collections::Generic::List<CppSharp::Parser::ParserDiagnostic^>^ Diagnostics
            {
                System::Collections::Generic::List<CppSharp::Parser::ParserDiagnostic^>^ get();
                void set(System::Collections::Generic::List<CppSharp::Parser::ParserDiagnostic^>^);
            }
        };

        public ref class ClangParser : ICppInstance
        {
        public:

            property ::CppSharp::CppParser::ClangParser* NativePtr;
            property System::IntPtr Instance
            {
                virtual System::IntPtr get();
                virtual void set(System::IntPtr instance);
            }

            ClangParser(::CppSharp::CppParser::ClangParser* native);
            ClangParser(System::IntPtr native);
            ClangParser();

            static CppSharp::Parser::ParserResult^ ParseHeader(CppSharp::Parser::ParserOptions^ Opts);

            static CppSharp::Parser::ParserResult^ ParseLibrary(CppSharp::Parser::ParserOptions^ Opts);

        };
    }
}
