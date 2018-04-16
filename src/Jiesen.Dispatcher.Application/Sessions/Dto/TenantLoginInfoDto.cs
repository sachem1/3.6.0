using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Jiesen.Dispatcher.MultiTenancy;

namespace Jiesen.Dispatcher.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
