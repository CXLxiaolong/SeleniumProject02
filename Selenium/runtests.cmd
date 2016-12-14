@pushd %~dp0

%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "Selenium.csproj"

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools

@set profile=%1

@set repostFile = %date:~,4%%date:~5,2%%date:~8,2%

@if "%profile%" == "" set profile=Default

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\Debug" /log:specrun.log /report:%~dp0\TestResult\AutoTestReport.html

:end
 
cd /d D:\Source\eclipse\workspace\interfaceDemo\interface
python smtp_op.py --receiver xiaolong.chen@dilatoit.com --content "Test run is completed, test report in the attachment" --attachments %~dp0\TestResult\AutoTestReport.html

@popd


