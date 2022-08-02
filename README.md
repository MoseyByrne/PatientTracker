# HairSalon

#### By _**Mo Byrne and Kyle Chinick**_

#### _WIP_

---

## Technologies Used

- _C#_
- _.NET_
- _HTML / CSHTML / RAZOR / LINQ_
- _Entity_

---

## Description

WIP

---

## Setup/Installation Requirements

1. Clone this repository to your desktop by executing `git clone https://github.com/kylechinick/PatientTracker` in your preferred terminal application.
2. In the terminal, cd into the VendorOrderTracker directory then execute `dotnet restore` in the terminal to auto-populate the directory with an `obj` directory and its required contents.
3. Ensure you have the required packages by running the following terminal commands for installing each:
   `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
   `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
   `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`

4. Create an 'appsettings.json' file in the project root and populate it with the following content, taking care to update with your unique database configurations:
   `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DB NAME];uid=root;pwd=[YOUR PASSWORD];" } }`

NOTE: [first_last] should be replaced with your own database name and [password] should be replaced by your password. Do not include square brackets in final configuration.

5. To start and run the app execute `dotnet run` or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each change to the codebase.

6. Optional: in order to test the application's class methods cd into the VendorOrderTracker.Tests folder and execute `dotnet test` in the terminal.

## Known Bugs

- N/A
