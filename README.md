# Calendar API

This project is an API for the Calendar App — an application that allows you to keep track of your daily tasks to enhance your discipline.

The main reason for creating this API was to apply all my knowledge to design robust, scalable, and maintainable software. I aimed to use everything I know to improve the architecture of this API because I wanted to have a solid example of a well-designed API that I can replicate in the future.

## 📁 Project Structure

The structure of the API is as follows. All projects are named using the Calendar.[Layer] convention.

The Data layer is responsible solely for inserting and retrieving data from the database.

The Services layer contains the business logic as well as error handling.

The Entities layer includes only the DTOs.

The Infrastructure layer is used for various purposes, such as connecting to external services or configuring dependency injection.

```
Solution "Calendar.API"
├── DataAccess
│   ├── Calendar.Data
│   └── Calendar.Data.Interfaces
├── Entities
│   └── Calendar.Entities
├── Infrastructure
│   └── Calendar.Infrastructure
├── Services
│   ├── Calendar.Services
│   └── Calendar.Services.Interfaces
└── Calendar.API
```

## Controlls

The convention for the controls is the next: