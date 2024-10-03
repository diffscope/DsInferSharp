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

public class Environment : PluginFactory {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Environment(global::System.IntPtr cPtr, bool cMemoryOwn) : base(dsinfer_csharp_bindingsPINVOKE.Environment_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Environment obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Environment obj) {
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
          dsinfer_csharp_bindingsPINVOKE.delete_Environment(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Environment() : this(dsinfer_csharp_bindingsPINVOKE.new_Environment(), true) {
  }

  public ContributeRegistry registry(int type) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.Environment_registry(swigCPtr, type);
    ContributeRegistry ret = (cPtr == global::System.IntPtr.Zero) ? null : new ContributeRegistry(cPtr, false);
    return ret;
  }

  public void addLibraryPath(string path) {
    dsinfer_csharp_bindingsPINVOKE.Environment_addLibraryPath(swigCPtr, path);
  }

  public void addLibraryPaths(PathList paths) {
    dsinfer_csharp_bindingsPINVOKE.Environment_addLibraryPaths(swigCPtr, PathList.getCPtr(paths));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLibraryPaths(PathList paths) {
    dsinfer_csharp_bindingsPINVOKE.Environment_setLibraryPaths(swigCPtr, PathList.getCPtr(paths));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PathList libraryPaths() {
    PathList ret = new PathList(dsinfer_csharp_bindingsPINVOKE.Environment_libraryPaths(swigCPtr), false);
    return ret;
  }

  public LibrarySpec openLibrary(string path, bool noLoad, Error error) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.Environment_openLibrary(swigCPtr, path, noLoad, Error.getCPtr(error));
    LibrarySpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new LibrarySpec(cPtr, false);
    return ret;
  }

  public bool closeLibrary(LibrarySpec spec) {
    bool ret = dsinfer_csharp_bindingsPINVOKE.Environment_closeLibrary(swigCPtr, LibrarySpec.getCPtr(spec));
    return ret;
  }

  public LibrarySpec findLibrary(string id, VersionNumber version) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.Environment_findLibrary(swigCPtr, id, VersionNumber.getCPtr(version));
    LibrarySpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new LibrarySpec(cPtr, false);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LibraryList findLibraries(string id) {
    LibraryList ret = new LibraryList(dsinfer_csharp_bindingsPINVOKE.Environment_findLibraries(swigCPtr, id), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LibraryList libraries() {
    LibraryList ret = new LibraryList(dsinfer_csharp_bindingsPINVOKE.Environment_libraries(swigCPtr), true);
    return ret;
  }

}

}