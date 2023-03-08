# Setup

Required .NET SDK installed to run.

## Running

`dotnet run`

or interactive run

`dotnet watch`

# Setting up your database

I setup with a free online PostgreSQL database ElephantSQL using the TinyTurtle (free) tier.
elephantsql.com

Get the URL ( you will get it from the Details of your instance) and put it in a user-secret like this:

`dotnet user-secrets set PGURL "<ENTERYOURURL>"`

confirm they have been inputted:

`dotnet user-secrets list`

Once you have yours setup go to:
https://customer.elephantsql.com/instance
( for instance)

There you can setup the database, with all the information contained in the `/sql` folder.

# API docs

https://localhost:7012/swagger