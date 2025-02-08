# BlazorTaskApp

Welcome to the **Blazor Tasks** project! 

### 📦 Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or any code editor of your choice
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or LocalDB)

### 🚧 Setup Instructions

#### 1. Clone the Project

First, clone the repository to your local machine. Open your terminal and run:

git clone https://github.com/Aditya-Bhargav-dev/BlazorTaskApp.git
cd BlazorTaskApp

#### 2. Configure the Database Connection

Set up the environment using `dotnet restore`, then apply the migrations using `dotnet ef database update`.

Update the `appsettings.json` file with your local database configuration. Change the line:


"Server=LocalDB;Database=BlazorTasksContext;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"


### 🚀 Features

- **Counter Component**: Simple Blazor Component for Counter.
- **Books Management**: Create, read, update, and delete tasks with ease.
- **Responsive Design**: A beautiful and responsive UI that works on all devices.
- **Search and Filter**: Quickly find tasks using search and filter options. <em>(yet to implement)</em>
- **Dark Mode**: Switch between light and dark themes for a personalized experience. <em>(yet to implement)</em>

### HomePage

![image](https://github.com/user-attachments/assets/3841dd61-e672-4385-8bcb-f5626566d819)

### Task 1 : Create a Simple Blazor Component for Counter 
  Navigate to the *Counter* option in the Nav Menu to see it in action!

  **Counter Menu and its functionality**

  ![image](https://github.com/user-attachments/assets/bdef99f8-c560-4408-ac70-dc9d15e8ae76)
  
  ![image](https://github.com/user-attachments/assets/00a1a64f-2803-4d0c-be6f-389153b98f92)

### Task 2 : Build a Simple CRUD Application - Books 
  Head over to the *Books* option in the Nav Menu to manage your book collection!

  **Book Menu and its functionality**

  - List of books

 ![image](https://github.com/user-attachments/assets/a4f353f9-a7d7-4c58-9822-2e398379e2bc)


  - Create a book

![image](https://github.com/user-attachments/assets/d508be7a-8cbe-48d4-888c-5f626e81ce86)


  - Details of book

![image](https://github.com/user-attachments/assets/4dd05935-7bf1-4408-af31-557c7964000a)


  - Edit book

![image](https://github.com/user-attachments/assets/0a1333eb-bc1e-4307-b1ae-7e1434153c6f)


  - Delete book

![image](https://github.com/user-attachments/assets/cd4e8821-8176-47c3-b552-3e617af87b08)

![image](https://github.com/user-attachments/assets/16e20337-1693-47a2-b1b8-6d9d33e30a71)

## 🛠️ Technologies Used

- **Blazor**: For building interactive web UIs.
- **Entity Framework Core**: For database operations.
- **SignalR**: For real-time web functionality.
- **Bootstrap**: For responsive design.

<p>
    Enjoy your journey through our application!
</p>
