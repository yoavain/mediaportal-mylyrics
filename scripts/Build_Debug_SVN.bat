@echo off
cls
Title Building MediaPortal MyLyrics (DEBUG)
cd ..

cd source

:: Prepare version
subwcrev .. LyricsEngine\Properties\AssemblyInfo.cs LyricsEngine\Properties\AssemblyInfo.cs
subwcrev .. "My Lyrics\Properties\AssemblyInfo.cs" "My Lyrics\Properties\AssemblyInfo.cs"
subwcrev .. TranslateProvider\Properties\AssemblyInfo.cs TranslateProvider\Properties\AssemblyInfo.cs

cd source
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBUILD.exe" /target:Rebuild /property:Configuration=DEBUG MyLyrics.sln

:: Revert version
svn revert LyricsEngine\Properties\AssemblyInfo.cs
svn revert "My Lyrics\Properties\AssemblyInfo.cs"
svn revert TranslateProvider\Properties\AssemblyInfo.cs

cd ..
cd scripts