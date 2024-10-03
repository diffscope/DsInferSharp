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

public class InferenceList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<InferenceSpec>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InferenceList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InferenceList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(InferenceList obj) {
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

  ~InferenceList() {
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
          dsinfer_csharp_bindingsPINVOKE.delete_InferenceList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public InferenceList(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (InferenceSpec element in c) {
      this.Add(element);
    }
  }

  public InferenceList(global::System.Collections.Generic.IEnumerable<InferenceSpec> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (InferenceSpec element in c) {
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

  public InferenceSpec this[int index]  {
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

  public void CopyTo(InferenceSpec[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(InferenceSpec[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, InferenceSpec[] array, int arrayIndex, int count)
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

  public InferenceSpec[] ToArray() {
    InferenceSpec[] array = new InferenceSpec[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<InferenceSpec> global::System.Collections.Generic.IEnumerable<InferenceSpec>.GetEnumerator() {
    return new InferenceListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new InferenceListEnumerator(this);
  }

  public InferenceListEnumerator GetEnumerator() {
    return new InferenceListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class InferenceListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<InferenceSpec>
  {
    private InferenceList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public InferenceListEnumerator(InferenceList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public InferenceSpec Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (InferenceSpec)currentObject;
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

  public InferenceList() : this(dsinfer_csharp_bindingsPINVOKE.new_InferenceList__SWIG_0(), true) {
  }

  public InferenceList(InferenceList other) : this(dsinfer_csharp_bindingsPINVOKE.new_InferenceList__SWIG_1(InferenceList.getCPtr(other)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_Clear(swigCPtr);
  }

  public void Add(InferenceSpec x) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_Add(swigCPtr, InferenceSpec.getCPtr(x));
  }

  private uint size() {
    uint ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_size(swigCPtr);
    return ret;
  }

  private bool empty() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_empty(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_reserve(swigCPtr, n);
  }

  public InferenceList(int capacity) : this(dsinfer_csharp_bindingsPINVOKE.new_InferenceList__SWIG_2(capacity), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  private InferenceSpec getitemcopy(int index) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceList_getitemcopy(swigCPtr, index);
    InferenceSpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceSpec(cPtr, false);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private InferenceSpec getitem(int index) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceList_getitem(swigCPtr, index);
    InferenceSpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceSpec(cPtr, false);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, InferenceSpec val) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_setitem(swigCPtr, index, InferenceSpec.getCPtr(val));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(InferenceList values) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_AddRange(swigCPtr, InferenceList.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public InferenceList GetRange(int index, int count) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceList_GetRange(swigCPtr, index, count);
    InferenceList ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceList(cPtr, true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, InferenceSpec x) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_Insert(swigCPtr, index, InferenceSpec.getCPtr(x));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, InferenceList values) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_InsertRange(swigCPtr, index, InferenceList.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_RemoveAt(swigCPtr, index);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_RemoveRange(swigCPtr, index, count);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static InferenceList Repeat(InferenceSpec value, int count) {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.InferenceList_Repeat(InferenceSpec.getCPtr(value), count);
    InferenceList ret = (cPtr == global::System.IntPtr.Zero) ? null : new InferenceList(cPtr, true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_Reverse__SWIG_1(swigCPtr, index, count);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, InferenceList values) {
    dsinfer_csharp_bindingsPINVOKE.InferenceList_SetRange(swigCPtr, index, InferenceList.getCPtr(values));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(InferenceSpec value) {
    bool ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_Contains(swigCPtr, InferenceSpec.getCPtr(value));
    return ret;
  }

  public int IndexOf(InferenceSpec value) {
    int ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_IndexOf(swigCPtr, InferenceSpec.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(InferenceSpec value) {
    int ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_LastIndexOf(swigCPtr, InferenceSpec.getCPtr(value));
    return ret;
  }

  public bool Remove(InferenceSpec value) {
    bool ret = dsinfer_csharp_bindingsPINVOKE.InferenceList_Remove(swigCPtr, InferenceSpec.getCPtr(value));
    return ret;
  }

}

}