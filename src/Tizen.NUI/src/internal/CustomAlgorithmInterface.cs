//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

//#define DOT_NET_CORE
#if DOT_NET_CORE
using System.Reflection;
#endif

namespace Tizen.NUI {

internal class CustomAlgorithmInterface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CustomAlgorithmInterface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CustomAlgorithmInterface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CustomAlgorithmInterface() {
    DisposeQueue.Instance.Add(this);
  }

  public virtual void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_CustomAlgorithmInterface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual Actor GetNextFocusableActor(Actor current, Actor proposed, View.FocusDirection direction) {
    Actor ret = new Actor(NDalicPINVOKE.CustomAlgorithmInterface_GetNextFocusableActor(swigCPtr, Actor.getCPtr(current), Actor.getCPtr(proposed), (int)direction), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CustomAlgorithmInterface() : this(NDalicPINVOKE.new_CustomAlgorithmInterface(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("GetNextFocusableActor", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateCustomAlgorithmInterface_0(SwigDirectorGetNextFocusableActor);
    NDalicPINVOKE.CustomAlgorithmInterface_director_connect(swigCPtr, swigDelegate0);
  }

#if DOT_NET_CORE
  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, methodTypes);
    bool hasDerivedMethod = this.GetType().GetTypeInfo().IsSubclassOf(typeof(CustomAlgorithmInterface));
    return hasDerivedMethod && (methodInfo != null);
  }
#else
  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(CustomAlgorithmInterface));
    return hasDerivedMethod;
  }
#endif

  private global::System.IntPtr SwigDirectorGetNextFocusableActor(global::System.IntPtr current, global::System.IntPtr proposed, int direction) {
    return Actor.getCPtr(GetNextFocusableActor(new Actor(current, true), new Actor(proposed, true), (View.FocusDirection)direction)).Handle;
  }

  public delegate global::System.IntPtr SwigDelegateCustomAlgorithmInterface_0(global::System.IntPtr current, global::System.IntPtr proposed, int direction);

  private SwigDelegateCustomAlgorithmInterface_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Actor), typeof(Actor), typeof(View.FocusDirection) };
}

}
