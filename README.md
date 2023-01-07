# Notes

Setup with a free online PostgreSQL database ElephantSQL using the TinyTurtle tier.

Get the URL ( you will get it from the Details of your instance) in a user-secret like this:

`dotnet user-secrets set PGURL "<ENTERYOURURL>"`

Once you have yours setup go to:
https://customer.elephantsql.com/instance
( for instance)

There you can setup the database, with all the information contained in the `/sql` folder.

# Runing backend

`dotnet run`

or interactive run

`dotnet watch`

# API docs

https://localhost:7012/swagger