//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using CppSharp.Runtime;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public enum ParserDiagnosticLevel
        {
            Ignored = 0,
            Note = 1,
            Warning = 2,
            Error = 3,
            Fatal = 4
        }

        public enum ParserResultKind
        {
            Success = 0,
            Error = 1,
            FileNotFound = 2
        }

        public enum SourceLocationKind
        {
            Invalid = 0,
            Builtin = 1,
            CommandLine = 2,
            System = 3,
            User = 4
        }

        public unsafe partial class ParserOptions : IDisposable, ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 116)]
            public struct Internal
            {
                [FieldOffset(0)]
                public Std.Vector IncludeDirs;

                [FieldOffset(12)]
                public Std.Vector SystemIncludeDirs;

                [FieldOffset(24)]
                public Std.Vector Defines;

                [FieldOffset(36)]
                public Std.Vector LibraryDirs;

                [FieldOffset(48)]
                public Std.String FileName;

                [FieldOffset(72)]
                public global::System.IntPtr Library;

                [FieldOffset(76)]
                public int ToolSetToUse;

                [FieldOffset(80)]
                public Std.String TargetTriple;

                [FieldOffset(104)]
                public bool NoStandardIncludes;

                [FieldOffset(105)]
                public bool NoBuiltinIncludes;

                [FieldOffset(106)]
                public bool MicrosoftMode;

                [FieldOffset(108)]
                public CppSharp.Parser.CppAbi Abi;

                [FieldOffset(112)]
                public bool Verbose;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserOptions@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserOptions0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserOptions@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserOptions2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            void ICppMarshal.MarshalManagedToNative(IntPtr instance)
            {
            }

            void ICppMarshal.MarshalNativeToManaged(IntPtr instance)
            {
            }

            internal ParserOptions(ParserOptions.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserOptions(ParserOptions.Internal native)
                : this(&native)
            {
            }

            internal ParserOptions(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserOptions()
            {
                __Instance = Marshal.AllocHGlobal(116);
                Internal.ParserOptions0(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public Std.Vector<Std.String> IncludeDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->IncludeDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IncludeDirs = value.Internal;
                }
            }

            public Std.Vector<Std.String> SystemIncludeDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->SystemIncludeDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->SystemIncludeDirs = value.Internal;
                }
            }

            public Std.Vector<Std.String> Defines
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->Defines);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Defines = value.Internal;
                }
            }

            public Std.Vector<Std.String> LibraryDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->LibraryDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LibraryDirs = value.Internal;
                }
            }

            public Std.String FileName
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FileName;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FileName = new Std.String();
                }
            }

            public CppSharp.Parser.Library Library
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    var __copy = new global::System.IntPtr(&__ptr->Library);
                    return new CppSharp.Parser.Library(__copy);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Library = value.__Instance;
                }
            }

            public int ToolSetToUse
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ToolSetToUse;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ToolSetToUse = value;
                }
            }

            public Std.String TargetTriple
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->TargetTriple;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->TargetTriple = new Std.String();
                }
            }

            public bool NoStandardIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoStandardIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoStandardIncludes = value;
                }
            }

            public bool NoBuiltinIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoBuiltinIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoBuiltinIncludes = value;
                }
            }

            public bool MicrosoftMode
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->MicrosoftMode;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->MicrosoftMode = value;
                }
            }

            public CppSharp.Parser.CppAbi Abi
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Abi;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Abi = value;
                }
            }

            public bool Verbose
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Verbose;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Verbose = value;
                }
            }
        }

        public unsafe partial class ParserDiagnostic : IDisposable, ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 60)]
            public struct Internal
            {
                [FieldOffset(0)]
                public Std.String FileName;

                [FieldOffset(24)]
                public Std.String Message;

                [FieldOffset(48)]
                public CppSharp.Parser.ParserDiagnosticLevel Level;

                [FieldOffset(52)]
                public int LineNumber;

                [FieldOffset(56)]
                public int ColumnNumber;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserDiagnostic@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserDiagnostic1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserDiagnostic@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserDiagnostic2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            void ICppMarshal.MarshalManagedToNative(IntPtr instance)
            {
            }

            void ICppMarshal.MarshalNativeToManaged(IntPtr instance)
            {
            }

            internal ParserDiagnostic(ParserDiagnostic.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserDiagnostic(ParserDiagnostic.Internal native)
                : this(&native)
            {
            }

            internal ParserDiagnostic(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserDiagnostic()
            {
                __Instance = Marshal.AllocHGlobal(60);
                Internal.ParserDiagnostic1(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public Std.String FileName
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FileName;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FileName = new Std.String();
                }
            }

            public Std.String Message
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Message;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Message = new Std.String();
                }
            }

            public CppSharp.Parser.ParserDiagnosticLevel Level
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Level;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Level = value;
                }
            }

            public int LineNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LineNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LineNumber = value;
                }
            }

            public int ColumnNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ColumnNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ColumnNumber = value;
                }
            }
        }

        public unsafe partial class ParserResult : IDisposable, ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 20)]
            public struct Internal
            {
                [FieldOffset(0)]
                public CppSharp.Parser.ParserResultKind Kind;

                [FieldOffset(4)]
                public global::System.IntPtr Library;

                [FieldOffset(8)]
                public Std.Vector Diagnostics;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserResult@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserResult1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserResult@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserResult2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            void ICppMarshal.MarshalManagedToNative(IntPtr instance)
            {
            }

            void ICppMarshal.MarshalNativeToManaged(IntPtr instance)
            {
            }

            internal ParserResult(ParserResult.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserResult(ParserResult.Internal native)
                : this(&native)
            {
            }

            internal ParserResult(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserResult()
            {
                __Instance = Marshal.AllocHGlobal(20);
                Internal.ParserResult1(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public CppSharp.Parser.ParserResultKind Kind
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Kind;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Kind = value;
                }
            }

            public CppSharp.Parser.Library Library
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    var __copy = new global::System.IntPtr(&__ptr->Library);
                    return new CppSharp.Parser.Library(__copy);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Library = value.__Instance;
                }
            }

            public Std.Vector<CppSharp.Parser.ParserDiagnostic> Diagnostics
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<CppSharp.Parser.ParserDiagnostic>(__ptr->Diagnostics);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Diagnostics = value.Internal;
                }
            }
        }

        public unsafe partial class ClangParser : IDisposable, ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 1)]
            public struct Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ClangParser@CppParser@CppSharp@@QAE@ABV012@@Z")]
                public static extern global::System.IntPtr ClangParser1(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="?ParseHeader@ClangParser@CppParser@CppSharp@@SAPAUParserResult@23@PAUParserOptions@23@@Z")]
                public static extern global::System.IntPtr ParseHeader0(global::System.IntPtr Opts);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="?ParseLibrary@ClangParser@CppParser@CppSharp@@SAPAUParserResult@23@PAUParserOptions@23@@Z")]
                public static extern global::System.IntPtr ParseLibrary0(global::System.IntPtr Opts);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            void ICppMarshal.MarshalManagedToNative(IntPtr instance)
            {
            }

            void ICppMarshal.MarshalNativeToManaged(IntPtr instance)
            {
            }

            internal ClangParser(ClangParser.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ClangParser(ClangParser.Internal native)
                : this(&native)
            {
            }

            internal ClangParser(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ClangParser()
            {
                __Instance = Marshal.AllocHGlobal(1);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public static CppSharp.Parser.ParserResult ParseHeader(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts.__Instance;
                var __ret = Internal.ParseHeader0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return new CppSharp.Parser.ParserResult(__ret);
            }

            public static CppSharp.Parser.ParserResult ParseLibrary(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts.__Instance;
                var __ret = Internal.ParseLibrary0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return new CppSharp.Parser.ParserResult(__ret);
            }
        }
    }
}
