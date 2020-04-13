@echo off

if "%1"=="h" goto begin

start mshta vbscript:createobject("wscript.shell").run("""%~nx0"" h",0)(window.close)&&exit

:begin

echo CreateObject("Scripting.FileSystemObject").DeleteFile(WScript.ScriptFullName) >%Temp%\Wait.vbs

echo wscript.sleep 600 >>%Temp%\Wait.vbs

start /wait %Temp%\Wait.vbs

pssuspend64 StudentMain.exe