#region ensamblado Windows.Foundation.UniversalApiContract, Version=5.19041.10.0, Culture=neutral, PublicKeyToken=null
// ubicación desconocida
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using WinRT;
using WinRT.Interop;

namespace Windows.Media.MediaProperties
{
    [WindowsRuntimeType("Windows.Foundation.UniversalApiContract")]
    [ProjectedRuntimeClass("_default")]
    [ObjectReferenceWrapper("_inner")]
    [ContractVersion(typeof(UniversalApiContract), 65536u)]
    [SupportedOSPlatform("Windows10.0.10240.0")]
    public sealed class ImageEncodingProperties : IMediaEncodingProperties, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<ImageEncodingProperties>
    {
        internal class _IImageEncodingPropertiesStatics : IWinRTObject, IDynamicInterfaceCastable
        {
            private IObjectReference _obj;

            private static readonly WeakLazy<_IImageEncodingPropertiesStatics> _instance = new WeakLazy<_IImageEncodingPropertiesStatics>();

            internal static IImageEncodingPropertiesStatics Instance => (IImageEncodingPropertiesStatics)_instance.Value;

            IObjectReference IWinRTObject.NativeObject => _obj;

            bool IWinRTObject.HasUnwrappableNativeObject => false;

            ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>();


            ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, object>();


            public _IImageEncodingPropertiesStatics()
            {
                _obj = new BaseActivationFactory("Windows.Media.MediaProperties", "Windows.Media.MediaProperties.ImageEncodingProperties")._As(GuidGenerator.GetIID(typeof(IImageEncodingPropertiesStatics).GetHelperType()));
            }
        }

        internal class _IImageEncodingPropertiesStatics2 : IWinRTObject, IDynamicInterfaceCastable
        {
            private IObjectReference _obj;

            private static readonly WeakLazy<_IImageEncodingPropertiesStatics2> _instance = new WeakLazy<_IImageEncodingPropertiesStatics2>();

            internal static IImageEncodingPropertiesStatics2 Instance => (IImageEncodingPropertiesStatics2)_instance.Value;

            IObjectReference IWinRTObject.NativeObject => _obj;

            bool IWinRTObject.HasUnwrappableNativeObject => false;

            ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>();


            ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, object>();


            public _IImageEncodingPropertiesStatics2()
            {
                _obj = new BaseActivationFactory("Windows.Media.MediaProperties", "Windows.Media.MediaProperties.ImageEncodingProperties")._As(GuidGenerator.GetIID(typeof(IImageEncodingPropertiesStatics2).GetHelperType()));
            }
        }

        internal class _IImageEncodingPropertiesStatics3 : IWinRTObject, IDynamicInterfaceCastable
        {
            private IObjectReference _obj;

            private static readonly WeakLazy<_IImageEncodingPropertiesStatics3> _instance = new WeakLazy<_IImageEncodingPropertiesStatics3>();

            internal static IImageEncodingPropertiesStatics3 Instance => (IImageEncodingPropertiesStatics3)_instance.Value;

            IObjectReference IWinRTObject.NativeObject => _obj;

            bool IWinRTObject.HasUnwrappableNativeObject => false;

            ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>();


            ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData
            {
                get;
            } = new ConcurrentDictionary<RuntimeTypeHandle, object>();


            public _IImageEncodingPropertiesStatics3()
            {
                _obj = new BaseActivationFactory("Windows.Media.MediaProperties", "Windows.Media.MediaProperties.ImageEncodingProperties")._As(GuidGenerator.GetIID(typeof(IImageEncodingPropertiesStatics3).GetHelperType()));
            }
        }

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        private struct InterfaceTag<I>
        {
        }

        private IObjectReference _inner;

        private readonly Lazy<IImageEncodingProperties> _defaultLazy;

        private readonly Dictionary<Type, object> _lazyInterfaces;

        internal static BaseActivationFactory _factory = new BaseActivationFactory("Windows.Media.MediaProperties", "Windows.Media.MediaProperties.ImageEncodingProperties");

        private IntPtr ThisPtr
        {
            get
            {
                if (_inner != null)
                {
                    return _inner.ThisPtr;
                }

                return ((IWinRTObject)this).NativeObject.ThisPtr;
            }
        }

        private IImageEncodingProperties _default => _defaultLazy.Value;

        bool IWinRTObject.HasUnwrappableNativeObject => true;

        IObjectReference IWinRTObject.NativeObject => _inner;

        ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache
        {
            get;
        } = new ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>();


        ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData
        {
            get;
        } = new ConcurrentDictionary<RuntimeTypeHandle, object>();


        MediaPropertySet IMediaEncodingProperties.Properties => Properties;

        string IMediaEncodingProperties.Subtype
        {
            get
            {
                return Subtype;
            }
            set
            {
                Subtype = value;
            }
        }

        string IMediaEncodingProperties.Type => Type;

        public uint Height
        {
            get
            {
                return _default.Height;
            }
            set
            {
                _default.Height = value;
            }
        }

        public MediaPropertySet Properties => AsInternal(default(InterfaceTag<IMediaEncodingProperties>)).Properties;

        public string Subtype
        {
            get
            {
                return AsInternal(default(InterfaceTag<IMediaEncodingProperties>)).Subtype;
            }
            set
            {
                AsInternal(default(InterfaceTag<IMediaEncodingProperties>)).Subtype = value;
            }
        }

        public string Type => AsInternal(default(InterfaceTag<IMediaEncodingProperties>)).Type;

        public uint Width
        {
            get
            {
                return _default.Width;
            }
            set
            {
                _default.Width = value;
            }
        }

        public ImageEncodingProperties()
            : this(ActivationFactory<ImageEncodingProperties>.ActivateInstance<IUnknownVftbl>())
        {
            ComWrappersSupport.RegisterObjectForInterface(this, ThisPtr);
            ComWrappersHelper.Init(_inner, addRefFromTrackerSource: false);
        }

        public static I As<I>()
        {
            return _factory.AsInterface<I>();
        }

        public static ImageEncodingProperties CreateJpeg()
        {
            return _IImageEncodingPropertiesStatics.Instance.CreateJpeg();
        }

        public static ImageEncodingProperties CreatePng()
        {
            return _IImageEncodingPropertiesStatics.Instance.CreatePng();
        }

        public static ImageEncodingProperties CreateJpegXR()
        {
            return _IImageEncodingPropertiesStatics.Instance.CreateJpegXR();
        }

        public static ImageEncodingProperties CreateUncompressed(MediaPixelFormat format)
        {
            return _IImageEncodingPropertiesStatics2.Instance.CreateUncompressed(format);
        }

        public static ImageEncodingProperties CreateBmp()
        {
            return _IImageEncodingPropertiesStatics2.Instance.CreateBmp();
        }

        [SupportedOSPlatform("Windows10.0.17763.0")]
        public static ImageEncodingProperties CreateHeif()
        {
            return _IImageEncodingPropertiesStatics3.Instance.CreateHeif();
        }

        public static ImageEncodingProperties FromAbi(IntPtr thisPtr)
        {
            if (thisPtr == IntPtr.Zero)
            {
                return null;
            }

            return MarshalInspectable<ImageEncodingProperties>.FromAbi(thisPtr);
        }

        internal ImageEncodingProperties(IObjectReference objRef)
        {
            _inner = objRef.As(GuidGenerator.GetIID(typeof(IImageEncodingProperties).GetHelperType()));
            _defaultLazy = new Lazy<IImageEncodingProperties>(() => (IImageEncodingProperties)new SingleInterfaceOptimizedObject(typeof(IImageEncodingProperties), _inner));
            _lazyInterfaces = new Dictionary<Type, object>
            {
                {
                    typeof(IMediaEncodingProperties),
                    new Lazy<IMediaEncodingProperties>(() => (IMediaEncodingProperties)new SingleInterfaceOptimizedObject(typeof(IMediaEncodingProperties), _inner ?? ((IWinRTObject)this).NativeObject))
                },
                {
                    typeof(IImageEncodingProperties2),
                    new Lazy<IImageEncodingProperties2>(() => (IImageEncodingProperties2)new SingleInterfaceOptimizedObject(typeof(IImageEncodingProperties2), _inner ?? ((IWinRTObject)this).NativeObject))
                }
            };
        }

        public static bool operator ==(ImageEncodingProperties x, ImageEncodingProperties y)
        {
            return (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
        }

        public static bool operator !=(ImageEncodingProperties x, ImageEncodingProperties y)
        {
            return !(x == y);
        }

        public bool Equals(ImageEncodingProperties other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            ImageEncodingProperties imageEncodingProperties = obj as ImageEncodingProperties;
            if ((object)imageEncodingProperties != null)
            {
                return this == imageEncodingProperties;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ThisPtr.GetHashCode();
        }

        private IImageEncodingProperties AsInternal(InterfaceTag<IImageEncodingProperties> _)
        {
            return _default;
        }

        private IMediaEncodingProperties AsInternal(InterfaceTag<IMediaEncodingProperties> _)
        {
            return ((Lazy<IMediaEncodingProperties>)_lazyInterfaces[typeof(IMediaEncodingProperties)]).Value;
        }

        private IImageEncodingProperties2 AsInternal(InterfaceTag<IImageEncodingProperties2> _)
        {
            return ((Lazy<IImageEncodingProperties2>)_lazyInterfaces[typeof(IImageEncodingProperties2)]).Value;
        }

        [SupportedOSPlatform("Windows10.0.17134.0")]
        public ImageEncodingProperties Copy()
        {
            return AsInternal(default(InterfaceTag<IImageEncodingProperties2>)).Copy();
        }

        private bool IsOverridableInterface(Guid iid)
        {
            return false;
        }

        CustomQueryInterfaceResult ICustomQueryInterface.GetInterface(ref Guid iid, out IntPtr ppv)
        {
            ppv = IntPtr.Zero;
            if (IsOverridableInterface(iid) || typeof(IInspectable).GUID == iid)
            {
                return CustomQueryInterfaceResult.NotHandled;
            }

            if (((IWinRTObject)this).NativeObject.TryAs(iid, out ObjectReference<IUnknownVftbl> objRef) >= 0)
            {
                using (objRef)
                {
                    ppv = objRef.GetRef();
                    return CustomQueryInterfaceResult.Handled;
                }
            }

            return CustomQueryInterfaceResult.NotHandled;
        }
    }
}
#if false // Registro de descompilación
"235" elementos en caché
------------------
Resolver: "System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Runtime.dll"
------------------
Resolver: "WinRT.Runtime, Version=1.2.0.0, Culture=neutral, PublicKeyToken=99ea127f02d97709"
Se encontró un solo ensamblado: "WinRT.Runtime, Version=1.2.0.0, Culture=neutral, PublicKeyToken=99ea127f02d97709"
Cargar desde: "C:\Users\pikachu\.nuget\packages\microsoft.windows.cswinrt\1.2.5\lib\net5.0\WinRT.Runtime.dll"
------------------
Resolver: "System.Runtime.InteropServices, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Runtime.InteropServices.dll"
------------------
Resolver: "Windows.Foundation.FoundationContract, Version=5.19041.4.1, Culture=neutral, PublicKeyToken=null"
Se encontró un solo ensamblado: "Windows.Foundation.FoundationContract, Version=5.19041.4.1, Culture=neutral, PublicKeyToken=null"
Cargar desde: "C:\Users\pikachu\.nuget\packages\windowscontracts.net.foundation.foundationcontract\5.19041.4.1\lib\net5.0\Windows.Foundation.FoundationContract.dll"
------------------
Resolver: "System.Threading, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Threading, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Threading.dll"
------------------
Resolver: "System.Collections.Concurrent, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Collections.Concurrent, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Collections.Concurrent.dll"
------------------
Resolver: "System.Numerics.Vectors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Numerics.Vectors, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Numerics.Vectors.dll"
------------------
Resolver: "Windows.Networking.Connectivity.WwanContract, Version=5.19041.2.1, Culture=neutral, PublicKeyToken=null"
Se encontró un solo ensamblado: "Windows.Networking.Connectivity.WwanContract, Version=5.19041.2.1, Culture=neutral, PublicKeyToken=null"
Cargar desde: "C:\Users\pikachu\.nuget\packages\windowscontracts.net.networking.connectivity.wwancontract\5.19041.2.1\lib\net5.0\Windows.Networking.Connectivity.WwanContract.dll"
------------------
Resolver: "System.Collections, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Collections, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
AVISO: No coinciden las versiones. Se esperaba "5.0.0.0", se obtuvo "6.0.0.0"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Collections.dll"
------------------
Resolver: "System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Se encontró un solo ensamblado: "System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Cargar desde: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.3\ref\net6.0\System.Runtime.dll"
#endif
