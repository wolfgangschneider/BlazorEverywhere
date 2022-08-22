using Microsoft.JSInterop;



namespace Tpl.Core.InterfacesIpl
{
    public class HardWhare : Tpl.Core.Interfaces.IHardWhare , IAsyncDisposable
    {
        
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;
        public HardWhare(IJSRuntime JSRuntime)
        {
            moduleTask = new(() => JSRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/Tpl.core/hardwhareInfo.js").AsTask());
        }
       
        public bool IsBrowser => true;

        public async Task<String> GetOs()
        {
            try
            {
                var module = await moduleTask.Value;
                var ret = await module.InvokeAsync<string>("getOs");
                return ret;
             
            }
            catch(Exception ex)
            {
                var s= ex.ToString();
                return"cannot detect";
            }
        }
        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }

    }
}
