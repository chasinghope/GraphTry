set LUBAN_DLL=luban\Luban.dll
set CONF_ROOT=cfgs
set OUTPUT_CODE_DIR=../UnityProject/Assets/Scripts/GenCfgs
set OUTPUT_DATA_DIR=../UnityProject/Assets/Resources\BundleRes\cfgs\jsons

dotnet %LUBAN_DLL% ^
    -t client ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%OUTPUT_CODE_DIR%^
    -x outputDataDir=%OUTPUT_DATA_DIR%

pause