﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPISelfHost
{
    public class APIRunner
    {
        public void Run()
        {
            using (WebApp.Start<Startup>(url: "http://localhost:9000"))
            {
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
