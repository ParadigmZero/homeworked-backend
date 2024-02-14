# Setup

Requires Microsoft .NET SDK 8.0 installed to run. This was developed on 7, but just put over to 8.

# Other pre-requisite steps

<https://aka.ms/aspnet/https-trust-dev-cert>

Linux:
<https://aka.ms/dev-certs-trust>

dotnet dev-certs https --trust

## Running

`dotnet run`

or interactive run

`dotnet watch`

# Setting up your database

I setup with a free online PostgreSQL database ElephantSQL using the TinyTurtle (free) tier.
( see <https://www.elephantsql.com/> )

Get the URL ( you will get it from the Details of your instance) and put it in a user-secret like this:

`dotnet user-secrets set PGURL "<ENTERYOURURL>"`

confirm they have been inputted:

`dotnet user-secrets list`

Once you have yours setup go to:
<https://customer.elephantsql.com/instance>
( for instance)

There you can setup the database, with all the information contained in the `/sql` folder.

# API docs

<https://localhost:7012/swagger>