@echo off
pushd %~dp0
%systemroot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /codebase "Release\SearchBar.dll"