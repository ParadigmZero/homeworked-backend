# Setup

You will need the .NET SDK (using version 7 here) installed, in order to run this project.

## Database

Setup with a free online PostgreSQL database ElephantSQL using the TinyTurtle tier.
elephantsql.com

Get the URL ( you will get it from the Details of your instance) in a user-secret like this:

`dotnet user-secrets set PGURL "<ENTERYOURURL>"`

Once you have yours setup go to:
https://customer.elephantsql.com/instance
( for instance)

There you can setup the database, with all the information contained in the `/sql` folder.

This has been deployed online with Railway at:
https://homeworked.up.railway.app/

Here is some more information if you want it:

In Variables are entered PGURL ( with the value from your Database provider )
and PORT ( probably 3000 ) check what port Railway uses.

Note this is an example project, and the information in the database is not confidential in any way.

## Deployment

Deployed for free on Heroku at the following URL:


Used the following buildpack to be able to deploy this dotnet core project on Heroku:
https://github.com/jincod/dotnetcore-buildpack

# Running locally etc

`dotnet run`

or interactive run

`dotnet watch`

# API docs

https://localhost:7012/swagger