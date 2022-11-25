#region TryCatch
//bool isParse = true;
//try
//{
//    //string name = null;
//    //Console.WriteLine(name.ToString());



//    int[] arr = new int[2];

//    arr[0] = 5;

//    string name = null;
//    if(name is null)
//    {
//        throw new NullReferenceException();
//    }


//    isParse = true;

//    Console.WriteLine(arr[0]);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//    isParse= false;
//}
//finally
//{
//    if (isParse)
//    {
//        Console.WriteLine("Welcome");
//    }
//    else
//    {
//        Console.WriteLine("");
//    }
//}
#endregion


//GetNameById(2);

//static void GetNameById(int? id)
//{
//	try
//	{
//		if(id==null) 
//		{ 
//			throw new ArgumentNullException();
//		}
//		else
//		{
//			Console.WriteLine("Name Id: "+id);
//		}

//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}

//}

//using Practice_Exceptions.Controllers;




//AccountController account=new AccountController();
//account.Register();


//AccountController account=new AccountController();
//account.Register();

using Practice_Exceptions.Controllers;

AccountController account=new AccountController();
account.Register();






