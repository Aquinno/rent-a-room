namespace ReservaDeQuartos {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? (1 ~ 10): ");
            int num = int.Parse(Console.ReadLine());
            Rooms[] vect = new Rooms[11]; //Creating the array of rooms
            // I used 11 because the rooms are from 1 to 10, it's easier to manage the array
            // If someone use the room 0, congratulations, you found a Easter Egg
            for (int i = 0; i < num; i++) {
                Console.WriteLine($"Rent #{i+1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                byte room = byte.Parse(Console.ReadLine());
                if (vect[room] != null) { //Checking if the room is avaiable
                    Console.WriteLine("Room already rented.");
                    Console.WriteLine(" ");
                    i--; // Decrement i to repeat the loop
                    continue;
                }
                else {
                    vect[room] = new Rooms { Name = name, Email = email, Room = room };
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Busy Rooms:"); //Showing the rented rooms
            for (int i = 0; i < vect.Length; i++) {
                if (vect[i] != null) {
                    Console.WriteLine($"{vect[i].Room}: {vect[i].Name}, {vect[i].Email}");
                }
            }
        }
    }
}
