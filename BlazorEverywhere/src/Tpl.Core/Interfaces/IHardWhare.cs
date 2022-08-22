

namespace Tpl.Core.Interfaces
{
    public interface IHardWhare
    {
        public bool IsBrowser { get; }


        public async Task<String> GetOs()
        {
            return await Task.FromResult("Not Implemented");
        }

        //public async Task<String> GetBrowser()
        //{
        //    return await Task.FromResult("Not Implemented");
        //}

    }
}
