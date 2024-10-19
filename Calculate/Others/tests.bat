@echo off

set EDITION=Professional
set VSMAIN=C:\Program Files\Microsoft Visual Studio\2022
set MSTEST=%VSMAIN%\%EDITION%\Common7\IDE\mstest.exe
set VSTEST=%VSMAIN%\%EDITION%\Common7\IDE\Extensions\TestPlatform\vstest.console.exe
set MSBUILD=%VSMAIN%\%EDITION%\MSBuild\Current\Bin\msbuild.exe
set WindowsSDK_ExecutablePath=C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools

echo Building Windows Solution

NuGet.exe restore FieldLogic.Windows.sln -verbosity quiet
"%MSBUILD%" -m /p:Configuration=Release /t:Build FieldLogic.Windows.sln > build.log

if %ERRORLEVEL%==0 goto SuccessNET
echo Windows Build Failed
echo View "build.log" for details
goto Failure
:SuccessNET

rd /s/q TestResults >nul 2>&1
::"%MSTEST%" /testcontainer:Tests\bin\Release\Tests.dll /resultsfile:TestResults.trx /nologo
"%VSTEST%" Tests\bin\Release\Tests.dll /Logger:html;LogFileName=TestResults.html /Logger:trx;LogFileName=TestResults.trx
