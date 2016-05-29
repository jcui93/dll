using System;
using System.Runtime.InteropServices;

namespace import_test
{
	public class importer
	{
		[DllImport ("/home/jcui93/Desktop/import_test/vehicle-scan.so",
		CallingConvention = CallingConvention.StdCall )] 
		unsafe static extern void cmd_lescan (int dev_id, int argc, char** argv);

		unsafe public importer ()
		{
			//char[,] tester = {{'v','e','h','i','c','l','e','-','s','c','a','n'}};
			try{
				cmd_lescan(-1, 1, null);
			}
			catch(DllNotFoundException e){
				Console.WriteLine (e.ToString ());
			}
			catch(EntryPointNotFoundException e){
				Console.WriteLine (e.ToString ());
			}
		}
	}
}

