# LetMeKnow

LetMeKnow is a task management application built with .NET and Maui. It allows users to create, manage, and track their tasks.

## Features

- Task Creation: Users can create tasks with a start and end date.
- Task Management: Users can view their tasks and mark them as done.
- Task Tracking: The application keeps track of the tasks and notifies the user of the tasks that are not yet done.

## Project Structure

The project is structured into several parts:

- `DataClass`: This directory contains the classes related to the data model of the application, such as `ToDo` and `ToDoControler`.
- `Platforms`: This directory contains platform-specific code. For example, `Windows/App.xaml.cs` contains the initialization code for the Windows platform.
- `Models`: This directory contains the models used in the application, such as `ControlerModel`.

## Code Overview

- `ToDoControler.cs`: Contains the `GetTodo` method which retrieves the first task that is not done.
- `App.xaml.cs`: Initializes the application.
- `Todo.cs`: Contains the `ToDo` class which represents a task. It also contains the `Viewing` and `IComparable<ToDo>` implementations.
- `App.g.i.cs`: Contains the `InitializeComponent` and `Main` methods which are responsible for the application startup.
- `AppShell.xaml.cs`: Initializes the main components of the application.
- `MauiProgram.cs`: Contains the `CreateMauiApp` method which sets up the Maui application.
- `ControlerModel.cs`: Contains the `SetToDo` method which updates the current task.

## How to Run

To run the application, you need to have .NET and Maui installed on your machine. Once you have these installed, you can run the application using the command `dotnet run` in the root directory of the project.