Programming II – Pet Application.
PetApp
A high-level view of the Pet Shop application is shown below. You will build a system by
precisely following the specifications below. A sample output is provided at the end of this
document. You must match the format of the output as close as possible.
Do not use the class diagram below or even the UML object diagram to develop your code.
Please read the specification/description of each type including all the members before starting
to implement the system.
It is recommended that you implement each type in the order that they are specified.

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/3a5ac6a9-d054-46d7-a073-694e3e4e6fdf)

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/788f6abc-197d-4767-b7ed-5c2a82d7c2d3)

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/774fa877-c279-4745-b60a-f455537abc0c)

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/4c0a8c84-cab4-4109-8f9e-acd285667509)

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/c65e3c31-a7b7-43c1-ba3f-62480235c6f6)

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/a26452c3-ee7f-4113-8590-5a9bef114c0d)

Test Harness 
Copy the following into your main method and write the missing statements.
//Creating and printing a pet object - 2 marks
Console.WriteLine("Creating and printing a pet");
//write the statement to instantiate the Pet class and display the
//resulting object
List<Pet> pets;
Console.WriteLine("\n\nGetting a collection of pets");
//write the statement to get a list of pets - 2 marks
//(By calling the CreatePets() method)
//and display the resulting collection
double weight = 1.0;
Console.WriteLine($"\n\nDisplaying all pets heavier than {weight}kg");
//write the statement to filter out only the - 2 marks
//required pets from the previous collection
string filename = "pets.json";
Console.WriteLine($"\n\nSerializing the pets to the file {filename}");
//write the statement to save the current - 2 marks
//collection to a file

![image](https://github.com/dyeyniyel/comp123-Test02-PetApp/assets/158533198/b90d633f-1e6a-4270-b7a0-de68d5ab901d)

