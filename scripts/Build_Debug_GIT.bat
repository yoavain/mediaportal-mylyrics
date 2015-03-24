@echo off
cls
Title Building MediaPortal MyLyrics (DEBUG)
cd ..

cd source

setlocal enabledelayedexpansion

:: Prepare version
for /f "tokens=*" %%a in ('git rev-list HEAD --count') do set REVISION=%%a 
set REVISION=%REVISION: =%
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" LyricsEngine\Properties\AssemblyInfo.cs
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" "My Lyrics\Properties\AssemblyInfo.cs"
"..\scripts\Tools\sed.exe" -i "s/\$WCREV\$/%REVISION%/g" TranslateProvider\Properties\AssemblyInfo.cs

"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBUILD.exe" /target:Rebuild /property:Configuration=DEBUG MyLyrics.sln

:: Revert version
git checkout LyricsEngine\Properties\AssemblyInfo.cs
git checkout "My Lyrics\Properties\AssemblyInfo.cs"
git checkout TranslateProvider\Properties\AssemblyInfo.cs

cd ..
cd scripts