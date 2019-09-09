@{
    Version = "3.0";
    Ignore = $true; 
    Type = "POWERSHELL";
    Name = "demo-plugin-v1"; 
    Id = "1593D9E1-A416-4681-8B10-369CECDF309A"; 
    TBE = 60; 
    ConfigListDefaults = @{
        "kenaflow" = "cool"
    }; 
    AlertAddresses = @(); 
    RER = $false; 

	#writeMailsToDiskDuringDebug = $true;
    #alwaysWriteMailsToDiskInsteadSending = $false; 
    #redirectAllMails = @(); 
    #SendOutputToMainProcess = $false;
    #DumpRerEventDataToLog = $false
    #SaveRerEventsAfterProcessing = $false
	
	CustomData = @{
		Plugin = @{
			"Name" = "Demo Plugin V1";
		}
	}
}

if(!$kenaflow){import-module "c:\kenaflow\kenaflow.runtime.dll";Test-KFConfig;exit}
