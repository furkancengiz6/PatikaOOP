# Practical - Inheritance

Welcome to the **Practical - Inheritance** project repository! 🚀 This project demonstrates the fundamental concepts of **Object-Oriented Programming (OOP)** in C#, focusing on **inheritance** with real-world examples.

## 📝 Overview
This project showcases:
- How to create a base class (`BasePerson`).
- How to inherit from a base class to create specialized classes (`Student` and `Teacher`).
- How to use properties, constructors, and methods to manage and display information.
- Polymorphism via the use of `virtual` and `override` keywords.

## 📂 Project Structure
```
Practical - Inheritance/
├── BasePerson.cs       # Abstract base class with common properties and methods
├── Student.cs          # Derived class representing a student
├── Teacher.cs          # Derived class representing a teacher
├── Program.cs          # Entry point of the application
```

## 🔑 Key Concepts

### 1. **Base Class** (`BasePerson`)
The `BasePerson` class is an abstract class that provides shared properties and methods for all persons.

- **Properties:**
  - `FirstName`
  - `LastName`
- **Methods:**
  - `ShowInfo()`: A `virtual` method to display common information.
- **Constructor:**
  Initializes `FirstName` and `LastName`.

### 2. **Derived Classes**

#### **Student** (`Student`)
- **Additional Property:**
  - `StudentNumber`
- **Overridden Method:**
  - `ShowInfo()`: Displays the student’s information including their `StudentNumber`.

#### **Teacher** (`Teacher`)
- **Additional Property:**
  - `Salary`
- **Overridden Method:**
  - `ShowInfo()`: Displays the teacher’s information including their `Salary`.

### 3. **Polymorphism**
- The `ShowInfo()` method in `BasePerson` is marked as `virtual`.
- Both `Student` and `Teacher` override this method to provide specialized implementations.

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/furkancengiz6/PatikaOOP.git
   ```

2. Navigate to the project directory:
   ```bash
   cd PatikaOOP/Practical - Inheritance
   ```

3. Open the project in your favorite IDE (e.g., Visual Studio, Rider).

4. Build and run the project.

## 📋 Example Output
```plaintext
Student Information:
First Name: Ahmet
Last Name: Yılmaz
Student Number: 12345

Teacher Information:
First Name: Ayşe
Last Name: Kaya
Salary: 8500.50
```

## 🌟 Features
- **Code Reusability:** Shared functionality in the base class.
- **Customization:** Specialized behavior in derived classes.
- **Clean Design:** Simple and modular structure.

## 🤝 Contributing
Feel free to fork this repository, make your changes, and submit a pull request. Contributions are always welcome!

## 📄 License
This project is licensed under the MIT License. See the [LICENSE](../LICENSE) file for details.

---

Happy Coding! 💻

