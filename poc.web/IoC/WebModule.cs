﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poc.web.IoC
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}