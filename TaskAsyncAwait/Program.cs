Task task = new Task(() => Console.WriteLine("Icra baslayir..."));
Task.Delay(3000).Wait();
Console.WriteLine("Bitdi");
task.Start();
task.Wait();
#region MyRegion
//async Task ShowMessage(string message)
//{
//    Console.WriteLine(message);
//    await Task.Delay(1000);
//    Console.WriteLine("Ready");
//}
//await ShowMessage("Loading"); 

#endregion


