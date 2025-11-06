using Data.Metods;
using Service.Services;

//ShowMethod showMethod = new ShowMethod();
//string result = await showMethod.ShowMessage("Hello Aync world");
//Console.WriteLine(result);
StudentService studentService=new StudentService();
await studentService.GetAllAsync();
