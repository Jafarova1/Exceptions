using Practice.Controller;

LibraryController.GetAll();

var result = LibraryController.GetAllBooksByLIbrary(m => m.LibraryId == 1);

foreach (var item in result)
{
    Console.WriteLine(item.Name+" "+item.Author);
}