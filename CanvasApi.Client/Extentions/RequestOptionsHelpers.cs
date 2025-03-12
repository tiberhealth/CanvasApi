namespace CanvasApi.Client.Extentions;

internal static class RequestOptionsHelpers
{
    internal static TOptions GetOptions<TOptions, TConcrete>(this Action<TOptions> func, Action<TConcrete> pre = null)
        where TOptions : class
        where TConcrete: TOptions, new()
    {
        var concrete = new TConcrete();
        pre?.Invoke(concrete);
        func?.Invoke(concrete);

        return concrete;
    }
}