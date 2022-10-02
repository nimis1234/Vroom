1. Install Asp.net core 3.1
2. Install Entity Framework core
3. install Enitity SQLSERVER
4.Microsoft.EntityFrameworkCore.Tools

-----------------To setup DbContext-----------------
1. firt creat domain class
2. Add Dbcontext
3. Add connection string to Appstring
4.call connection string from Startup class->configuration service
5.Add Dbset

-----------------------Db Migration----------------------------
1. Add-Migrations 
        used to add migrations
2Update-Dabtabase
         used to update database

3.Remove-Migration - used to removeMgrations


4. if you want to remove first migratation

             update-database 0 (0 means that only migrationadded in the project)
             remove-migrtaions