using Microsoft.JSInterop;

namespace Tpl.BlazorServer.InterfacesIpl;

public class BlazorServerHardWhare : Tpl.Core.Interfaces.IHardWhare
{
    public BlazorServerHardWhare()
    {
    }

    public bool IsBrowser => true;

    public async Task<String> GetOs()
    {
        return await Task.FromResult<string>( "when need something special for BlazoServer Imp. it here");
    }
}
