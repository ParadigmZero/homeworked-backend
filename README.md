Backend (NodeJS with TypeScript) to the HomeWorked, frontend found here: <https://github.com/ParadigmZero/HomeWorkedFrontend>

S3 bucket and object setup info here:
<https://github.com/ParadigmZero/homeworked-terraform-iac>

# Setup

Requires Microsoft .NET SDK 8.0 installed to run. This was developed on 7, but put settings as 8.

## Running

`dotnet run`

or interactive run:

`dotnet watch`

# Setting up your database

## Local/Docker

Docker needs to be installed.

Database up and seed with example data:

`docker compose up -d`

Database down

`docker compose down -d`

Set the user secrets to use this database:

dotnet user-secrets set PGURL "postgresql://user:password@localhost:5432/database"

## Deployed database ideas

For a deployed database here are some ideas for a free PostgreSQL database.

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