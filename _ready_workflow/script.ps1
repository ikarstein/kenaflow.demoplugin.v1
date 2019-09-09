param($wf, $eventData, $config)


# This is the code you need to debug. It does not hurt the workflow during prdoction but can be removed of course. 
if($wf-eq$null){import-module "c:\kenaflow\kenaflow.runtime.dll";Invoke-Kenaflow -plugin "c:\source\plugin\bin\debug\kenaflow.demopluginv1.dll";exit}


Write-KFLog (Get-PluginTestV1)

