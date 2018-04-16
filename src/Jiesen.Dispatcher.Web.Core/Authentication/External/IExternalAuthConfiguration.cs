using System.Collections.Generic;

namespace Jiesen.Dispatcher.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
