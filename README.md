# ClassPortal
A simplified portal for viewing schedule and transcript data.

This is a simplified sucessor to the 
[universityofscouting](https://github.com/Longhorn-Council-BSA/universityofscouting) 
transcript and schedule viewer.

## Connection String

Set the connection string to a SqlServer.  (For example 
Azure SQL, SQLExpress, or MS SQL Server)

The app will search for a connection string in this order:
1. Configuration entry: ConnectionStrings:DataContext
2. Environment variable: CONNECTION_STRING
3. If neither of the above are found, a local SQLExpress 
   instance will be used.

If the user in the connection string has access to do so,
the database, tables, and sample data will be created
automatically.

## Administration

This app does not have a built-in admin panel.  Instead, 
data is to be managed using MS SQL Server Management Studio
or MS Access connections (or similar).

## Development

This app intentioanlly keeps to a minimal feature set 
based on ASP.NET Core 5 and Entity Framework in order to 
make ongoing maintenance as simple as possible.

