using Tpl.Core.Interfaces;

namespace Tpl.Maui.InterfacesIpl
{
    public class  MauiHardWhare : IHardWhare
    {
        public bool IsBrowser => false;

        public async Task<String> GetOs()
        {
            return await Task.FromResult(DeviceInfo.Platform.ToString());
        }

    }
}
