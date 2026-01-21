// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Input a count of elements");
Int32.TryParse(Console.ReadLine(), out var nElems);
var iArray = new int[nElems];
var oRnd = new Random();
for (int i = 0; i < nElems; i++)
{
    var nItem = oRnd.Next(1, 20);
    iArray[i] = nItem;
}
var nProduct = 1;
for (int i = 0; i < nElems; i++)
{
    nProduct *= iArray[i];
    Console.Write(iArray[i] + " ");
}
Console.WriteLine($"\r\nThe Product of {nElems} elements of the array is:{nProduct}");
Console.Read();
