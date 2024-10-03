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

public class VectorLibraryDependency : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<LibraryDependency>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorLibraryDependency(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorLibraryDependency obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(VectorLibraryDependency obj) {
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

  ~VectorLibraryDependency() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          dsinfer_csharp_bindingsPINVOKE.delete_VectorLibraryDependency(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorLibraryDependency(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (LibraryDependency element in c) {
      this.Add(element);
    }
  }

  public VectorLibraryDependency(global::System.Collections.Generic.IEnumerable<LibraryDependency> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (LibraryDependency element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public LibraryDependency this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public bool IsEmpty {
    get {
      return empty();
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(LibraryDependency[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(LibraryDependency[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, LibraryDependency[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public LibraryDependency[] ToArray() {
    LibraryDependency[] array = new LibraryDependency[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<LibraryDependency> global::System.Collections.Generic.IEnumerable<LibraryDependency>.GetEnumerator() {
    return new VectorLibraryDependencyEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorLibraryDependencyEnumerator(this);
  }

  public VectorLibraryDependencyEnumerator GetEnumerator() {
    return new VectorLibraryDependencyEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorLibraryDependencyEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<LibraryDependency>
  {
    private VectorLibraryDependency collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorLibraryDependencyEnumerator(VectorLibraryDependency collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public LibraryDependency Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (LibraryDependency)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public VectorLibraryDependency() : this(dsinfer_csharp_bindingsPINVOKE.new_VectorLibraryDependency__SWIG_0(), true) {
  }

  public VectorLibraryDependency(VectorLibraryDependency other) : this(dsinfer_csharp_bindingsPINVOKE.new_VectorLibraryDependency__SWIG_1(VectorLibraryDependency.getCPtr(other)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Clear(swigCPtr);
  }

  public void Add(LibraryDependency x) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Add(swigCPtr, LibraryDependency.getCPtr(x));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_size(swigCPtr);
    return ret;
  }

  private bool empty() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_empty(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_reserve(swigCPtr, n);
  }

  public VectorLibraryDependency(int capacity) : this(dsinfer_csharp_bindingsPINVOKE.new_VectorLibraryDependency__SWIG_2(capacity), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  private LibraryDependency getitemcopy(int index) {
    LibraryDependency ret = new LibraryDependency(dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_getitemcopy(swigCPtr, index), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private LibraryDependency getitem(int index) {
    LibraryDependency ret = new LibraryDependency(dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_getitem(swigCPtr, index), false);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, LibraryDependency val) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_setitem(swigCPtr, index, LibraryDependency.getCPtr(val));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorLibraryDependency values) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_AddRange(swigCPtr, VectorLibraryDependency.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorLibraryDependency GetRange(int index, int count) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_GetRange(swigCPtr, index, count);
    VectorLibraryDependency ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorLibraryDependency(cPtr, true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, LibraryDependency x) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Insert(swigCPtr, index, LibraryDependency.getCPtr(x));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorLibraryDependency values) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_InsertRange(swigCPtr, index, VectorLibraryDependency.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_RemoveAt(swigCPtr, index);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_RemoveRange(swigCPtr, index, count);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorLibraryDependency Repeat(LibraryDependency value, int count) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Repeat(LibraryDependency.getCPtr(value), count);
    VectorLibraryDependency ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorLibraryDependency(cPtr, true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_Reverse__SWIG_1(swigCPtr, index, count);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorLibraryDependency values) {
    dsinfer_csharp_bindingsPINVOKE.VectorLibraryDependency_SetRange(swigCPtr, index, VectorLibraryDependency.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}