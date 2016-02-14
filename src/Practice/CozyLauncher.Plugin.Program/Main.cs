﻿using CozyLauncher.PluginBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CozyLauncher.Plugin.Program
{
    public class Main : IPlugin
    {
        private PluginInitContext context_;

        public PluginInfo Init(PluginInitContext context)
        {
            context_ = context;
            var info = new PluginInfo();
            info.Keyword = "*";
            return info;
        }

        public List<Result> Query(Query query)
        {
            var rl      = new List<Result>();
            var fileSet = new HashSet<string>();
            var EnvVar  = Environment.GetEnvironmentVariable("Path").Split(';');

            foreach (var path in EnvVar)
            {
                try
                {
                    var ActPath = Path.Combine(path, query.RawQuery + ".exe").ToLower();
                    if (!fileSet.Contains(ActPath) && File.Exists(ActPath))
                    {
                        var r = new Result()
                        {
                            Title = query.RawQuery,
                            SubTitle = ActPath,
                            IcoPath = "app",
                            Score = 100,
                            Action = e =>
                           {
                               Process.Start(ActPath);
                               context_.Api.HideAndClear();
                               return true;
                           },
                        };
                        rl.Add(r);
                        fileSet.Add(ActPath);
                    }
                }
                catch
                {
                    continue;
                }
            }

            if(rl.Count > 0)
            {
                return rl;
            }

            return null;
        }
    }
}
