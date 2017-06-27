//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------
using SizeT = System.UInt64;

namespace Swigged.cuda {

class cudaPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="SWIGRegisterExceptionCallbacks_cuda")]
    public static extern void SWIGRegisterExceptionCallbacks_cuda(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_cuda")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_cuda(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.Exception(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.Exception(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_cuda(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_cuda(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.Exception("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(cudaPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(cudaPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="SWIGRegisterStringCallback_cuda")]
    public static extern void SWIGRegisterStringCallback_cuda(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_cuda(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static cudaPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda___CUDA_API_VERSION_get___")]
  public static extern int __CUDA_API_VERSION_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_VERSION_get___")]
  public static extern int CUDA_VERSION_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_IPC_HANDLE_SIZE_get___")]
  public static extern int CU_IPC_HANDLE_SIZE_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTALLOC_PORTABLE_get___")]
  public static extern int CU_MEMHOSTALLOC_PORTABLE_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTALLOC_DEVICEMAP_get___")]
  public static extern int CU_MEMHOSTALLOC_DEVICEMAP_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTALLOC_WRITECOMBINED_get___")]
  public static extern int CU_MEMHOSTALLOC_WRITECOMBINED_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTREGISTER_PORTABLE_get___")]
  public static extern int CU_MEMHOSTREGISTER_PORTABLE_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTREGISTER_DEVICEMAP_get___")]
  public static extern int CU_MEMHOSTREGISTER_DEVICEMAP_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_MEMHOSTREGISTER_IOMEMORY_get___")]
  public static extern int CU_MEMHOSTREGISTER_IOMEMORY_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_LAYERED_get___")]
  public static extern int CUDA_ARRAY3D_LAYERED_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_2DARRAY_get___")]
  public static extern int CUDA_ARRAY3D_2DARRAY_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_SURFACE_LDST_get___")]
  public static extern int CUDA_ARRAY3D_SURFACE_LDST_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_CUBEMAP_get___")]
  public static extern int CUDA_ARRAY3D_CUBEMAP_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_TEXTURE_GATHER_get___")]
  public static extern int CUDA_ARRAY3D_TEXTURE_GATHER_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CUDA_ARRAY3D_DEPTH_TEXTURE_get___")]
  public static extern int CUDA_ARRAY3D_DEPTH_TEXTURE_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_TRSA_OVERRIDE_FORMAT_get___")]
  public static extern int CU_TRSA_OVERRIDE_FORMAT_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_TRSF_READ_AS_INTEGER_get___")]
  public static extern int CU_TRSF_READ_AS_INTEGER_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_TRSF_NORMALIZED_COORDINATES_get___")]
  public static extern int CU_TRSF_NORMALIZED_COORDINATES_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_TRSF_SRGB_get___")]
  public static extern int CU_TRSF_SRGB_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_CU_PARAM_TR_DEFAULT_get___")]
  public static extern int CU_PARAM_TR_DEFAULT_get();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuGetErrorString___")]
  public static extern int cuGetErrorString(int jarg1, out System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuGetErrorName___")]
  public static extern int cuGetErrorName(int jarg1, out System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuInit___")]
  public static extern int cuInit(uint jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDriverGetVersion___")]
  public static extern int cuDriverGetVersion(out int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGet___")]
  public static extern int cuDeviceGet(out int jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetCount___")]
  public static extern int cuDeviceGetCount(out int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetName___")]
  public static extern int cuDeviceGetName(string jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceTotalMem_v2___")]
  public static extern int cuDeviceTotalMem_v2(out SizeT jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetAttribute___")]
  public static extern int cuDeviceGetAttribute(out int jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceComputeCapability___")]
  public static extern int cuDeviceComputeCapability(out int jarg1, out int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDevicePrimaryCtxRetain___")]
  public static extern int cuDevicePrimaryCtxRetain(out CUcontext jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDevicePrimaryCtxRelease___")]
  public static extern int cuDevicePrimaryCtxRelease(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDevicePrimaryCtxSetFlags___")]
  public static extern int cuDevicePrimaryCtxSetFlags(int jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDevicePrimaryCtxGetState___")]
  public static extern int cuDevicePrimaryCtxGetState(int jarg1, out uint jarg2, out int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDevicePrimaryCtxReset___")]
  public static extern int cuDevicePrimaryCtxReset(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxCreate_v2___")]
  public static extern int cuCtxCreate_v2(out CUcontext jarg1, uint jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxDestroy_v2___")]
  public static extern int cuCtxDestroy_v2(CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxPushCurrent_v2___")]
  public static extern int cuCtxPushCurrent_v2(CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxPopCurrent_v2___")]
  public static extern int cuCtxPopCurrent_v2(out CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxSetCurrent___")]
  public static extern int cuCtxSetCurrent(CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetCurrent___")]
  public static extern int cuCtxGetCurrent(out CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetDevice___")]
  public static extern int cuCtxGetDevice(out int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetFlags___")]
  public static extern int cuCtxGetFlags(out uint jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxSynchronize___")]
  public static extern int cuCtxSynchronize();

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxSetLimit___")]
  public static extern int cuCtxSetLimit(int jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetLimit___")]
  public static extern int cuCtxGetLimit(out SizeT jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetCacheConfig___")]
  public static extern int cuCtxGetCacheConfig(out CUfunc_cache jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxSetCacheConfig___")]
  public static extern int cuCtxSetCacheConfig(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetSharedMemConfig___")]
  public static extern int cuCtxGetSharedMemConfig(out CUsharedconfig jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxSetSharedMemConfig___")]
  public static extern int cuCtxSetSharedMemConfig(CUsharedconfig jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetApiVersion___")]
  public static extern int cuCtxGetApiVersion(CUcontext jarg1, out uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxGetStreamPriorityRange___")]
  public static extern int cuCtxGetStreamPriorityRange(out int jarg1, out int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxAttach___")]
  public static extern int cuCtxAttach(out CUcontext jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxDetach___")]
  public static extern int cuCtxDetach(CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleLoad___")]
  public static extern int cuModuleLoad(out CUmodule jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleLoadData___")]
  public static extern int cuModuleLoadData(out CUmodule jarg1, System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleLoadFatBinary___")]
  public static extern int cuModuleLoadFatBinary(out CUmodule jarg1, System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleUnload___")]
  public static extern int cuModuleUnload(CUmodule jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleGetFunction___")]
  public static extern int cuModuleGetFunction(out CUfunction jarg1, CUmodule jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuModuleGetGlobal_v2___")]
  public static extern int cuModuleGetGlobal_v2(out uint jarg1, out SizeT jarg2, CUmodule jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuLinkDestroy___")]
  public static extern int cuLinkDestroy(CUlinkState jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemGetInfo_v2___")]
  public static extern int cuMemGetInfo_v2(out SizeT jarg1, out SizeT jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemAlloc_v2___")]
  public static extern int cuMemAlloc_v2(out uint jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemAllocPitch_v2___")]
  public static extern int cuMemAllocPitch_v2(out uint jarg1, out SizeT jarg2, uint jarg3, uint jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemFree_v2___")]
  public static extern int cuMemFree_v2(System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemGetAddressRange_v2___")]
  public static extern int cuMemGetAddressRange_v2(out uint jarg1, out SizeT jarg2, System.IntPtr jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemAllocHost_v2___")]
  public static extern int cuMemAllocHost_v2(out System.IntPtr jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemFreeHost___")]
  public static extern int cuMemFreeHost(System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemHostAlloc___")]
  public static extern int cuMemHostAlloc(out System.IntPtr jarg1, uint jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemHostGetDevicePointer_v2___")]
  public static extern int cuMemHostGetDevicePointer_v2(out uint jarg1, System.IntPtr jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemHostGetFlags___")]
  public static extern int cuMemHostGetFlags(out uint jarg1, System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemAllocManaged___")]
  public static extern int cuMemAllocManaged(out uint jarg1, uint jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetByPCIBusId___")]
  public static extern int cuDeviceGetByPCIBusId(out int jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetPCIBusId___")]
  public static extern int cuDeviceGetPCIBusId(string jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuIpcCloseMemHandle___")]
  public static extern int cuIpcCloseMemHandle(System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemHostRegister_v2___")]
  public static extern int cuMemHostRegister_v2(System.IntPtr jarg1, uint jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemHostUnregister___")]
  public static extern int cuMemHostUnregister(System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemcpy___")]
  public static extern int cuMemcpy(System.IntPtr jarg1, System.IntPtr jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemcpyPeer___")]
  public static extern int cuMemcpyPeer(System.IntPtr jarg1, CUcontext jarg2, System.IntPtr jarg3, CUcontext jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemcpyHtoD_v2___")]
  public static extern int cuMemcpyHtoD_v2(System.IntPtr jarg1, System.IntPtr jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemcpyDtoH_v2___")]
  public static extern int cuMemcpyDtoH_v2(System.IntPtr jarg1, System.IntPtr jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemcpyDtoD_v2___")]
  public static extern int cuMemcpyDtoD_v2(System.IntPtr jarg1, System.IntPtr jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD8_v2___")]
  public static extern int cuMemsetD8_v2(System.IntPtr jarg1, byte jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD16_v2___")]
  public static extern int cuMemsetD16_v2(System.IntPtr jarg1, ushort jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD32_v2___")]
  public static extern int cuMemsetD32_v2(System.IntPtr jarg1, uint jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD2D8_v2___")]
  public static extern int cuMemsetD2D8_v2(System.IntPtr jarg1, uint jarg2, byte jarg3, uint jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD2D16_v2___")]
  public static extern int cuMemsetD2D16_v2(System.IntPtr jarg1, uint jarg2, ushort jarg3, uint jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemsetD2D32_v2___")]
  public static extern int cuMemsetD2D32_v2(System.IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuPointerGetAttribute___")]
  public static extern int cuPointerGetAttribute(System.IntPtr jarg1, CUpointer_attribute jarg2, System.IntPtr jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemAdvise___")]
  public static extern int cuMemAdvise(System.IntPtr jarg1, uint jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemRangeGetAttribute___")]
  public static extern int cuMemRangeGetAttribute(System.IntPtr jarg1, uint jarg2, CUmem_range_attribute jarg3, System.IntPtr jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuMemRangeGetAttributes___")]
  public static extern int cuMemRangeGetAttributes(out System.IntPtr jarg1, out SizeT jarg2, out CUmem_range_attribute jarg3, uint jarg4, System.IntPtr jarg5, uint jarg6);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuPointerSetAttribute___")]
  public static extern int cuPointerSetAttribute(System.IntPtr jarg1, CUpointer_attribute jarg2, System.IntPtr jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuPointerGetAttributes___")]
  public static extern int cuPointerGetAttributes(uint jarg1, out CUpointer_attribute jarg2, out System.IntPtr jarg3, System.IntPtr jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuFuncGetAttribute___")]
  public static extern int cuFuncGetAttribute(out int jarg1, int jarg2, CUfunction jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuFuncSetCacheConfig___")]
  public static extern int cuFuncSetCacheConfig(CUfunction jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuFuncSetSharedMemConfig___")]
  public static extern int cuFuncSetSharedMemConfig(CUfunction jarg1, CUsharedconfig jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuLaunchKernel___")]
  public static extern int cuLaunchKernel(CUfunction jarg1, uint jarg2, uint jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7, uint jarg8, CUstream jarg9, out System.IntPtr jarg10, out System.IntPtr jarg11);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuFuncSetBlockShape___")]
  public static extern int cuFuncSetBlockShape(CUfunction jarg1, int jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuFuncSetSharedSize___")]
  public static extern int cuFuncSetSharedSize(CUfunction jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuParamSetSize___")]
  public static extern int cuParamSetSize(CUfunction jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuParamSeti___")]
  public static extern int cuParamSeti(CUfunction jarg1, int jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuParamSetf___")]
  public static extern int cuParamSetf(CUfunction jarg1, int jarg2, float jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuParamSetv___")]
  public static extern int cuParamSetv(CUfunction jarg1, int jarg2, System.IntPtr jarg3, uint jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuLaunch___")]
  public static extern int cuLaunch(CUfunction jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuLaunchGrid___")]
  public static extern int cuLaunchGrid(CUfunction jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuOccupancyMaxActiveBlocksPerMultiprocessor___")]
  public static extern int cuOccupancyMaxActiveBlocksPerMultiprocessor(out int jarg1, CUfunction jarg2, int jarg3, uint jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuOccupancyMaxActiveBlocksPerMultiprocessorWithFlags___")]
  public static extern int cuOccupancyMaxActiveBlocksPerMultiprocessorWithFlags(out int jarg1, CUfunction jarg2, int jarg3, uint jarg4, uint jarg5);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuTexObjectDestroy___")]
  public static extern int cuTexObjectDestroy(ulong jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuSurfObjectDestroy___")]
  public static extern int cuSurfObjectDestroy(ulong jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceCanAccessPeer___")]
  public static extern int cuDeviceCanAccessPeer(out int jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuDeviceGetP2PAttribute___")]
  public static extern int cuDeviceGetP2PAttribute(out int jarg1, int jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxEnablePeerAccess___")]
  public static extern int cuCtxEnablePeerAccess(CUcontext jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuCtxDisablePeerAccess___")]
  public static extern int cuCtxDisablePeerAccess(CUcontext jarg1);

  [global::System.Runtime.InteropServices.DllImport("swigged-cuda-native", EntryPoint="CSharp_Swiggedfcuda_cuGetExportTable___")]
  public static extern int cuGetExportTable(out System.IntPtr jarg1, ref CUuuid jarg2);
}

}