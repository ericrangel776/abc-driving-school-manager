# ABC Driving School Manager

A WinForms desktop app for managing a driving school's clients, staff, and class rosters. Connects to a SQL Server backend via ADO.NET, with data-bound grids that reload a person's schedule as their client or staff ID is entered.

## Setup

1. Restore/create the `F25_285B` database (see `ABCDriving/F25_285BDataSet.xsd` for the expected schema).
2. Open `ABCDriving/App.config` and `ABCDriving/Properties/Settings.settings`, and replace `YOUR_SERVER_NAME\INSTANCE_NAME` with your own SQL Server instance.
3. Open `ABCDriving.sln` in Visual Studio and run.
