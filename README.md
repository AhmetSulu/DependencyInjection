# Dependency Injection Example

This project demonstrates how to use **Dependency Injection** in a basic C# application. The example includes a `Teacher` and `ClassRoom` classes where the `ClassRoom` class depends on a `Teacher` instance. The teacher details are injected into the `ClassRoom` class using **Constructor Injection**. 

## Table of Contents

- [Project Structure](#project-structure)
- [Technologies](#technologies)
- [How to Run the Project](#how-to-run-the-project)
- [Example Output](#example-output)
- [License](#license)

## Project Structure

The project consists of the following components:

1. **`ITeacher` Interface**: An interface that defines the contract for a teacher class. It includes a method `GetInfo()` to retrieve teacher details.
   
2. **`Teacher` Class**: Implements the `ITeacher` interface. It has two properties, `FirstName` and `LastName`, which are set through the constructor. It also includes the `GetInfo()` method that returns the teacher's full name.

3. **`ClassRoom` Class**: Depends on the `ITeacher` instance. The teacher object is passed through the constructor using **Dependency Injection**. The class has a method `GetTeacherInfo()` that prints the teacher's information by calling the `GetInfo()` method of the teacher.

4. **`Program` Class**: The main entry point of the application. It creates instances of `Teacher` and injects them into the `ClassRoom` to display the teacher's information.

## Technologies

- **C#**
- **.NET Core**

## How to Run the Project

### Prerequisites

- Install **.NET Core SDK**: You can download the SDK from [here](https://dotnet.microsoft.com/download).

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/AhmetSulu/DependencyInjection.git
2. Navigate to the project directory:
   ```bash
   cd DependencyInjection
3. Run the project:
   ```bash
   dotnet run

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or support, please email ahmet.sulu1993@gmail.com
