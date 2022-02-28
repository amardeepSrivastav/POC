# POC

dotnet new webapi -n PointOfSale 
	dotnet -r PointOfSale
	
	dotnet add package Microsoft.EntityFrameworkCore
	dotnet add package Microsoft.EntityFrameworkCore.Design
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer

	
	to check ef is up and running >>	dotnet ef
	if ef is not up then run this command >> dotnet tool install --global dotnet-ef
	dotnet ef Migrations add initial Migrations
	dotnet ef  database update
	dotnet add package Automapper.Extensions.Microsoft.DependencyInjection
