﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5Blog.Startup))]
namespace Mvc5Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
