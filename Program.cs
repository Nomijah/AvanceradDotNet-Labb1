namespace AvanceradDotNetLabb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new collection and add five boxes.
            BoxCollection boxCollection = new BoxCollection();
            boxCollection.Add(new Box(1, 3, 5));
            boxCollection.Add(new Box(2, 7, 7));
            boxCollection.Add(new Box(5, 8, 10));
            boxCollection.Add(new Box(4, 10, 5));
            boxCollection.Add(new Box(10, 15, 10));
            Display(boxCollection);

            Console.WriteLine("--------------------------------------");

            // Remove a box from the list.
            Box toRemove = new Box(5,8,10);
            boxCollection.Remove(toRemove);
            Display(boxCollection);

            Console.WriteLine("--------------------------------------");

            // Add it again and check if it's in the collection.
            boxCollection.Add(toRemove);
            if (boxCollection.Contains(toRemove))
            {
                Console.WriteLine("The box exists in the collection.");
            } 
            else
            {
                Console.WriteLine("The box is not in the list.");
            }

            Console.WriteLine("--------------------------------------");

            // Check if another box is in the collection
            if (boxCollection.Contains(new Box(3,3,3)))
            {
                Console.WriteLine("The box exists in the collection.");
            }
            else
            {
                Console.WriteLine("The box is not in the list.");
            }

            Console.WriteLine("--------------------------------------");

            // Test if Add method prevents box with same dimensions being added.
            boxCollection.Add(new Box(2, 7, 7));

            Console.WriteLine("--------------------------------------");

            // Test if Add method prevents box with same volume being added.
            boxCollection.Add(new Box(7, 2, 7));

            Console.ReadKey();
        }

        public static void Display(BoxCollection boxCollection)
        {
            Console.WriteLine("Box nr.\tHeight\tWidth\tLength\tVolume");
            int counter = 1;
            foreach (Box box in boxCollection)
            {

                Console.WriteLine($"{counter}.\t{box.height} cm\t{box.width} " +
                    $"cm\t{box.length} cm\t{box.length * box.height * box.width} cm3");
                counter++;
            }
            Console.WriteLine();
        }
    }
}