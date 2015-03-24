@echo off
cls
Title Building MediaPortal MyLyrics (RELEASE)
cd ..

cd source

setlocal enabledelayedexpansion

if "%programfiles(x86)%XXX"=="XXX" goto 32BIT
	:: 64-bit
	set PROGS=%programfiles(x86)%
	goto CONT
:32BIT
	set PROGS=%ProgramFiles%	
:CONT

:: Prepare version
for /f "tokens=*" %%a in ('git rev-list HEAD --count') do set REVISION=%%a 
set REVISION=%REVISION: =%
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" LyricsEngine\Properties\AssemblyInfo.cs
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" "My Lyrics\Properties\AssemblyInfo.cs"
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" TranslateProvider\Properties\AssemblyInfo.cs

:: Build
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBUILD.exe" /target:Rebuild /property:Configuration=RELEASE /fl /flp:logfile=MyLyrics.log;verbosity=diagnostic MyLyrics.sln

:: Revert version
git checkout LyricsEngine\Properties\AssemblyInfo.cs
git checkout "My Lyrics\Properties\AssemblyInfo.cs"
git checkout TranslateProvider\Properties\AssemblyInfo.cs

:: Run test classes
"%PROGS%\Microsoft Visual Studio 11.0\Common7\IDE\MSTest.exe" /testcontainer:MyLyricsTests\bin\Release\MyLyricsTests.dll /resultsfile:..\scripts\testresult.xml

:: Parse test results
findstr "Counters total"  ..\scripts\testresult.xml > ..\scripts\line.txt

FOR /F "tokens=2-5" %%i IN (..\scripts\line.txt) DO (
	SET total=%%i
	SET executed=%%j
	SET passed=%%k
	SET error=%%l
)

SET total=%total:~7,-1%
SET executed=%executed:~10,-1%
SET passed=%passed:~8,-1%
SET error=%error:~7,-1%

del ..\scripts\testresult.xml
del ..\scripts\line.txt

echo.
if %total%==%passed% (
	echo All tests PASSED
) else (
	echo %error% TEST failed!!!
)
echo.

cd ..

cd scripts

pause

