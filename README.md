# EFDemo

This project shows how to use Entity Framework to connect a C# console app to the [Pagila](https://github.com/devrimgunduz/pagila) database.

* Fork this repo on GitHub.

* Go to Visual Studio to clone your forked repo:
	* `Git` menu -> `Clone Repository`
 	* Under `Browse Repositories`, click the `GitHub` button.
  * Select your `EFDemo` repo and make a note of where the project is being saved.
  * Click `Clone`.

* Open the solution:
	* `File` menu -> `Open` -> `Project/Solution`
	* Find where the project is saved, and open the `.slnx` file

* Go to Solution Explorer in Visual Studio
	* Right-click `EFDemo`
		* Select `Manage Nuget Packages`
		* Browse -> Search for these packages and install each one:
			* `Microsoft.Extensions.Configuration`
			* `Microsoft.Extensions.Configuration.Json`
			* `Microsoft.EntityFrameworkCore`
			* `Npgsql.EntityFrameworkCore.PostgreSQL`
	* Right-click `EFDemo`
		* Add -> New Item
		* Name the file `appsettings.json`
* Paste this code in appsettings.json:
	```
	{
		"ConnectionStrings": {
			"Pagila": "YOUR_CONNECTION_STRING_GOES_HERE"
		}
	}
	```
* Replace `YOUR_CONNECTION_STRING_GOES_HERE` with your connection string, which will look something like this:
	```
	Host=YOUR_SERVER_NAME_GOES_HERE;Port=5432;Database=pagila;Username=YOUR_USERNAME_GOES_HERE;Password=YOUR_PASSWORD_GOES_HERE
	```
* Click F5 or the play button to run the code.
