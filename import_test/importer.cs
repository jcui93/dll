using System;
using System.Runtime.InteropServices;

namespace import_test
{
	public class importer
	{
		[DllImport ("/home/clint/import_test/vehicle-scan.so",
		CallingConvention = CallingConvention.StdCall )] 
		unsafe static extern void cmd_lescan (int dev_id, int argc, char**argv);

		unsafe public importer ()
		{
			char** tester = null;
			try{
			cmd_lescan(-1, 1, tester);
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

