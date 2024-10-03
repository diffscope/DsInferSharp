using System.Runtime.InteropServices;

namespace DsInfer;

// https://stackoverflow.com/a/7160064/17177007
public static class SwigHelper
{
    public static T CastTo<T>(object from, bool cMemoryOwn = false)
    {
        var cPtrGetter = from.GetType().GetMethod("getCPtr",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        return cPtrGetter == null
            ? default(T)
            : (T)System.Activator.CreateInstance
            (
                typeof(T),
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance,
                null,
                new object[] { ((HandleRef)cPtrGetter.Invoke(null, new object[] { from })).Handle, cMemoryOwn },
                null
            );
    }
}