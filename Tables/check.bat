set LUBAN_DLL=../../luban\Luban.dll

dotnet %LUBAN_DLL% ^
    -t all ^
    --conf ../luban.conf ^
    -x forceLoadDatas=1

pause