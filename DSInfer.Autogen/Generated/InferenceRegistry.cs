//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace DsInfer {

public class InferenceRegistry : ContributeRegistry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal InferenceRegistry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InferenceRegistry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(InferenceRegistry obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          dsinfer_csharp_bindingsPINVOKE.delete_InferenceRegistry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public InferenceList findInferences(ContributeIdentifier identifier) {
    InferenceList ret = new InferenceList(dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_findInferences(swigCPtr, ContributeIdentifier.getCPtr(identifier)), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InferenceList inferences() {
    InferenceList ret = new InferenceList(dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_inferences(swigCPtr), true);
    return ret;
  }

  public InferenceDriver driver() {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_driver(swigCPtr);
    InferenceDriver ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceDriver(cPtr, false);
    return ret;
  }

  public InferenceDriver takeDriver() {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_takeDriver(swigCPtr);
    InferenceDriver ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceDriver(cPtr, false);
    return ret;
  }

  public void setDriver(InferenceDriver driver) {
    dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_setDriver(swigCPtr, InferenceDriver.getCPtr(driver));
  }

  public InferenceDriver createDriver(string key) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceRegistry_createDriver(swigCPtr, key);
    InferenceDriver ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceDriver(cPtr, false);
    return ret;
  }

}

}
