# Contact Agenda Console App (DraftAgenda)

## Project Overview
This is a robust console application designed to simulate a basic contact management system (an agenda). It serves as a practical demonstration of fundamental C# concepts, Object-Oriented Programming (OOP) principles, and defensive programming techniques.

The application manages a dynamic collection of Contact objects, ensuring data integrity through strong validation and providing sorted views.

## Key Features
The application supports the following operations via a main menu loop:

1. View Contacts (Sorted): Displays all contacts stored in the system.

	- Ascending order (Default, by Name, then LastName).

	- Descending order (by Name, then LastName).

2. Add Contact: Safely prompts the user for name, phone, and email, and adds the new, validated contact to the agenda.

3. Delete Last Contact: Removes the contact that was most recently added to the internal list structure.

4. Search Contact: Finds and confirms the existence of a contact by name.

5. Exit: Closes the application gracefully.

## Sorting Mechanism (IComparable)
The application uses the built-in C# sorting mechanism. The Contact class implements the IComparable<Contact> interface, using a robust CompareTo() method that sorts by:

1. Name (Primary Key, case-insensitive).

2. LastName (Secondary Key, case-insensitive, used for tie-breaking).