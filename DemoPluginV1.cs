/* part of kenaflow (https://kenaflow.com) */
/* Copyright by kenaro GmbH (https://www.kenaro.com) */
/* Written by Ingo Karstein */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;

namespace kenaflow.demoplugin.v1
{
    public class DemoPluginV1 : KenaflowPluginV1
    {
        private readonly KenaflowPluginConfigurationV1 MyConfig = new KenaflowPluginConfigurationV1
        {
            Id = Guid.Parse("{E9132626-B03B-415A-A73F-07CBF56D151E}"),
            Enabled = true,
            Name = "Demo Plugin v1",
            Version = new Version("1.0.0.0"),
            MinKenaflowVersion = new Version("3.0.12.0"),
            LogDebug = true,
            SupportedWorkflowTypes = new List<string> { "*" }
        };

        protected override KenaflowPluginConfigurationV1 GetPluginConfig(Options options)
        {
            //Return the Plugin Configuriation to kenaflow.
            LogNormal("Loading config of DemoPlugin v1");
            return MyConfig;
        }

        protected override void Loaded()
        {
            //Can be used to initialize the plugin after it was loaded and successfully registered.
        }

        protected override void Init(WFConfig config)
        {
            MyConfig.Enabled = true;
        }
    }

    [Cmdlet("Get", "PluginTestV1")]
    public class Test : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject($"Test: {DateTime.Now}");
        }
    }
}
