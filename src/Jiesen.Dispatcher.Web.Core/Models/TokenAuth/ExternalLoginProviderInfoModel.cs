using Abp.AutoMapper;
using Jiesen.Dispatcher.Authentication.External;

namespace Jiesen.Dispatcher.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
