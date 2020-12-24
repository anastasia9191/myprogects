﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StickyNotes
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Start>().As<IStart>();
            builder.RegisterType<FunctionalityOfTheNotes>().As<IFunctionalytyOfTheNotes>();
            builder.RegisterType<FileWork>().As<IFileWork>();
         
            return builder.Build();
        }
    }
}
