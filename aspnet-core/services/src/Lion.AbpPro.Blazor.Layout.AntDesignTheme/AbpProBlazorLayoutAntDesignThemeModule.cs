﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.Modularity;

namespace Lion.AbpPro.Blazor.Layout.AntDesignTheme
{
    public class AbpProBlazorLayoutAntDesignThemeModule: AbpModule
    {

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAntDesign();
        }
    }
}
