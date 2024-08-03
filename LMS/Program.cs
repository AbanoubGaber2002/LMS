using System;
using System.Linq;



namespace LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LMSEntities())
            {
                while (true)
                {
                    Console.WriteLine("Choose an operation:");
                    Console.WriteLine("1. Create New User");
                    Console.WriteLine("2. Read All Users");
                    Console.WriteLine("3. Update User");
                    Console.WriteLine("4. Delete User");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CreateUser(context);
                            break;
                        case "2":
                            ReadUsers(context);
                            break;
                        case "3":
                            UpdateUser(context);
                            break;
                        case "4":
                            DeleteUser(context);
                            break;
                        case "5":
                            return; // Exit the program
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }

        // Method to create a new user
        static void CreateUser(LMSEntities context)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine(); // Use secure method in real applications

            Console.Write("Enter Role (e.g., Student, Instructor, Admin): ");
            string role = Console.ReadLine();

            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PasswordHash = password,
                Role = role,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            context.Users.Add(newUser);
            context.SaveChanges();
            Console.WriteLine("New user added successfully.");
        }

        // Method to read all users
        static void ReadUsers(LMSEntities context)
        {
            var users = context.Users.ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.UserID}, Name: {user.FirstName} {user.LastName}, Email: {user.Email}, Role: {user.Role}");
            }
        }

        // Method to update an existing user
        static void UpdateUser(LMSEntities context)
        {
            Console.Write("Enter User ID to update: ");
            int userId = int.Parse(Console.ReadLine());

            var user = context.Users.Find(userId);
            if (user != null)
            {
                Console.Write("Enter New First Name (leave blank to keep current): ");
                string firstName = Console.ReadLine();
                Console.Write("Enter New Last Name (leave blank to keep current): ");
                string lastName = Console.ReadLine();
                Console.Write("Enter New Email (leave blank to keep current): ");
                string email = Console.ReadLine();
                Console.Write("Enter New Password (leave blank to keep current): ");
                string password = Console.ReadLine();
                Console.Write("Enter New Role (leave blank to keep current): ");
                string role = Console.ReadLine();

                if (!string.IsNullOrEmpty(firstName)) user.FirstName = firstName;
                if (!string.IsNullOrEmpty(lastName)) user.LastName = lastName;
                if (!string.IsNullOrEmpty(email)) user.Email = email;
                if (!string.IsNullOrEmpty(password)) user.PasswordHash = password;
                if (!string.IsNullOrEmpty(role)) user.Role = role;

                user.UpdatedAt = DateTime.Now;

                context.SaveChanges();
                Console.WriteLine("User updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static void DeleteUser(LMSEntities context)
        {
            Console.Write("Enter User ID to delete: ");
            int userId = int.Parse(Console.ReadLine());

            var user = context.Users.Find(userId);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }



    }
}
