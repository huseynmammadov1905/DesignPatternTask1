using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Abstract
{
	internal abstract class Dialog
	{
		public virtual void Render() => Console.WriteLine("Render");

		public abstract IButton CreateButton();
	}
}
