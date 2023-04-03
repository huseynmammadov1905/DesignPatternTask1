using ConsoleApp24.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Concretes
{
	internal class WindowsDialog : Dialog
	{
		public override void Render() => Console.WriteLine("WindowsDialog");
		
		public override IButton CreateButton()=> new WindowsButton();
		
	}
}
