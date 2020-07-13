#!/usr/bin/env bash
var1="2-new_project"
dotnet new console -n var1
dotnet build var1
dotnet run --project var1
