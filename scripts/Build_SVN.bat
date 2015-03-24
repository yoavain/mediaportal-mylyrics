@echo off
cls
Title Building MediaPortal MyLyrics (RELEASE)
cd ..

cd source

if "%programfiles(x86)%XXX"=="XXX" goto 32BIT
	:: 64-bit
	set PROGS=%programfiles(x86)%
	goto CONT
:32BIT
	set PROGS=%ProgramFiles%	
:CONT

:: Prepare version
subwcrev .. LyricsEngine\Properties\AssemblyInfo.cs LyricsEngine\Properties\AssemblyInfo.cs
subwcrev .. "My Lyrics\Properties\AssemblyInfo.cs" "My Lyrics\Properties\AssemblyInfo.cs"
subwcrev .. TranslateProvider\Properties\AssemblyInfo.cs TranslateProvider\Properties\AssemblyInfo.cs

:: Build
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBUILD.exe" /target:Rebuild /property:Configuration=RELEASE /fl /flp:logfile=MyLyrics.log;verbosity=diagnostic MyLyrics.sln

:: Revert version
svn revert LyricsEngine\Properties\AssemblyInfo.cs
svn revert "My Lyrics\Properties\AssemblyInfo.cs"
svn revert TranslateProvider\Properties\AssemblyInfo.cs

:: Run test classes
"%PROGS%\Microsoft Visual Studio 11.0\Common7\IDE\MSTest.exe" /testcontainer:MyLyricsTests\bin\Release\MyLyricsTests.dll /resultsfile:..\scripts\testresult.xml

:: Parse test results
findstr "Counters total"  ..\scripts\testresult.xml > ..\scripts\line.txt

setlocal EnableDelayedExpansion

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

