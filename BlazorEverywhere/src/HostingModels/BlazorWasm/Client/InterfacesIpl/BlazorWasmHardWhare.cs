namespace Tpl.BlazorWasm.InterfacesIpl
{
    public class  BlazorWasmHardWhare : Tpl.Core.Interfaces.IHardWhare
    {
        public string OS => GetOS();

        public bool IsBrowser => true;

        private static string GetOS()
        {
         
            return "Browser WASM";
        }

        public async Task<String> GetOs()
        {
            return await Task.FromResult("Browser WASM");
        }
    }
}
