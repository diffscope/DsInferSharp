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

public class SingerSpec : ContributeSpec {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SingerSpec(global::System.IntPtr cPtr, bool cMemoryOwn) : base(dsinfer_csharp_bindingsPINVOKE.SingerSpec_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SingerSpec obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(SingerSpec obj) {
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
          dsinfer_csharp_bindingsPINVOKE.delete_SingerSpec(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public string path() {
    string ret = dsinfer_csharp_bindingsPINVOKE.SingerSpec_path(swigCPtr);
    return ret;
}

  public string model() {
    string ret = dsinfer_csharp_bindingsPINVOKE.SingerSpec_model(swigCPtr);
    return ret;
  }

  public DisplayText name() {
    DisplayText ret = new DisplayText(dsinfer_csharp_bindingsPINVOKE.SingerSpec_name(swigCPtr), true);
    return ret;
  }

  public string avatar() {
    string ret = dsinfer_csharp_bindingsPINVOKE.SingerSpec_avatar(swigCPtr);
    return ret;
}

  public string background() {
    string ret = dsinfer_csharp_bindingsPINVOKE.SingerSpec_background(swigCPtr);
    return ret;
}

  public string demoAudio() {
    string ret = dsinfer_csharp_bindingsPINVOKE.SingerSpec_demoAudio(swigCPtr);
    return ret;
}

  public VectorSingerImport imports() {
    VectorSingerImport ret = new VectorSingerImport(dsinfer_csharp_bindingsPINVOKE.SingerSpec_imports(swigCPtr), false);
    return ret;
  }

  public JsonObject configuration() {
    JsonObject ret = new JsonObject(dsinfer_csharp_bindingsPINVOKE.SingerSpec_configuration(swigCPtr), true);
    return ret;
  }

  public VectorInference createInferences(Error error) {
    VectorInference ret = new VectorInference(dsinfer_csharp_bindingsPINVOKE.SingerSpec_createInferences(swigCPtr, Error.getCPtr(error)), true);
    return ret;
  }

}

}
