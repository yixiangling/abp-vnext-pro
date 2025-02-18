using Lion.AbpPro.DataDictionaryManagement.Localization;
using Volo.Abp.Application.Services;

namespace Lion.AbpPro.DataDictionaryManagement
{
    public abstract class DataDictionaryManagementAppService : ApplicationService
    {
        protected DataDictionaryManagementAppService()
        {
            LocalizationResource = typeof(DataDictionaryManagementResource);
            ObjectMapperContext = typeof(DataDictionaryManagementApplicationModule);
        }
    }
}
