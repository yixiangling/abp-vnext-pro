using Volo.Abp.Modularity;

namespace Lion.AbpPro.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationModule),
        typeof(DataDictionaryManagementDomainTestModule)
        )]
    public class DataDictionaryManagementApplicationTestModule : AbpModule
    {

    }
}
