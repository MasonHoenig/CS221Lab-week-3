namespace CS221Labs
{
    class ArraysLab
    {
        private static void Main()
        { 
            Movie m1 = new Movie("2001: A Space Odyssey", 1968, 4.3);
            Movie m2 = new Movie("Interstellar", 2014, 4.4);
            Movie m3 = new Movie("Dune", 2021, 3.9);
            Movie m4 = new Movie("Blade Runner 2049", 2017, 4.1);
            Movie m5 = new Movie("Moon", 2009, 3.9);

            Movie[] screens = [m1, m2, m3, m4, m5];

            
            for (int i = 0; i < screens.Length; i++)
            {
                Console.WriteLine(screens[i]);
                
            }
                       
            int total = m1.Year + m2.Year + m3.Year + m4.Year + m5.Year;
            double average = total / screens.Length;
            Math.Round(average, 2);

            Console.WriteLine($"The average year for the five movies showing is: {average}");

            bool[,] rectangular = new bool[8, 4];
            rectangular[0, 0] = false;
            rectangular[1, 0] = false;
            rectangular[2, 0] = false;
            rectangular[3, 0] = true;
            rectangular[4, 0] = true;
            rectangular[5, 0] = false;
            rectangular[6, 0] = false;
            rectangular[7, 0] = false;
            rectangular[0, 1] = false;
            rectangular[1, 1] = true;
            rectangular[2, 1] = true;
            rectangular[3, 1] = true;
            rectangular[4, 1] = true; 
            rectangular[5, 1] = true;
            rectangular[6, 1] = true;
            rectangular[7, 1] = false;
            rectangular[0, 2] = false;
            rectangular[1, 2] = false;
            rectangular[2, 2] = true;
            rectangular[3, 2] = true;
            rectangular[4, 2] = true;
            rectangular[5, 2] = true;
            rectangular[6, 2] = false;
            rectangular[7, 2] = false;
            rectangular[0, 3] = true;
            rectangular[1, 3] = true;
            rectangular[2, 3] = true;
            rectangular[3, 3] = false;
            rectangular[4, 3] = true;
            rectangular[5, 3] = false;
            rectangular[6, 3] = true;
            rectangular[7, 3] = true;

            Console.WriteLine("Avalible Seats:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rectangular[i, j] == false )
                    {

                        Console.WriteLine($"Row {j + 1} Seat {i + 1} is avalible");
                    }
                        
                }
            }
        }     
    }
}
