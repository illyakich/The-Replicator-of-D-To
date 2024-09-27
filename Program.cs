int[] array = new int[5] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
/* for  (int i = 0; i < 5; i++)
    Console.WriteLine(array[i]); */
int[] jarray = new int[5];

// copies the values of one array into the other
for (int i = 0; i < 5; i++)
    jarray[i] = array[i];

// added for readibility
Console.WriteLine("---------------");

// prints the values of the array "array" (C# just wont let your Console.WriteLine(array); to show it's contents.
for (int i = 0; i < 5; i++)
    Console.WriteLine(array[i]);

//added for readibility
Console.WriteLine("---------------");

// prints the values of the array "jarray".
for (int i = 0; i < 5; i++)
    Console.WriteLine(jarray[i]);
// lets gooo