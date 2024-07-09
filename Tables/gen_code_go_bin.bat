set LUBAN_DLL=luban\Luban.dll
set CONF_ROOT=cfgs
set OUTPUT_CODE_DIR=go-bin-code
set OUTPUT_DATA_DIR=go-bin
dotnet %LUBAN_DLL% ^
    -t server ^
    -c go-bin ^
    -d bin  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%OUTPUT_CODE_DIR%^
    -x outputDataDir=%OUTPUT_DATA_DIR%^
    -x lubanGoModule=demo/luban
pause