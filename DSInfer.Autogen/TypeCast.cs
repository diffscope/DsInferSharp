namespace DsInfer;

public static class TypeCastExtensions
{
    public static T Cast<T>(this ContributeRegistry type) where T : ContributeRegistry
    {
        return SwigHelper. CastTo<T>(type);
    }

    public static T Cast<T>(this ContributeSpec type) where T : ContributeSpec
    {
        return SwigHelper.CastTo<T>(type);
    }
}