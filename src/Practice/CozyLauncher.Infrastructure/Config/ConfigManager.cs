﻿using CozyLauncher.Infrastructure.Hotkey;
using CozyLauncher.Infrastructure.Version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CozyLauncher.Infrastructure.Config
{
    public class ConfigManager
    {
        public static ConfigManager Instance { get; set; } = new ConfigManager();

        public static string ConfigFilePath
        {
            get
            {
                return PathTransform.LocalFullPath(@"./config.json");
            }
        }

        public void Save()
        {
            var info = new ConfigInfo()
            {
                HotkeyConfigInfo = GlobalHotkey.Instance.Save(),
                VersionConfigInfo = VersionManager.Instance.Save(),
            };

            try
            {
                using (var fs = new FileStream(ConfigFilePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        var result = JsonConvert.SerializeObject(info);
                        if (!string.IsNullOrEmpty(result))
                        {
                            sw.Write(result);
                        }
                    }
                }
            }
            catch(Exception)
            {

            }
        }

        public void Load()
        {
            string result = null;
            ConfigInfo loadData = null;
            bool isError = false;

            try
            {
                using (var fs = new FileStream(ConfigFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (var fr = new StreamReader(fs))
                    {
                        result = fr.ReadToEnd();
                    }

                    loadData = JsonConvert.DeserializeObject<ConfigInfo>(result);
                    
                }
            }
            catch(Exception)
            {
            }

            if(!isError)
            {
                try
                {
                    GlobalHotkey.Instance.Load(loadData.HotkeyConfigInfo);
                }
                catch (Exception)
                {
                    GlobalHotkey.Instance.LoadDefault();
                    isError = true;
                }

                try
                {
                    VersionManager.Instance.Load(loadData.VersionConfigInfo);
                }
                catch (Exception)
                {
                    VersionManager.Instance.LoadDefaullt();
                    isError = true;
                }
            }

            if(isError)
            {
                Save();
            }
        }
    }
}
