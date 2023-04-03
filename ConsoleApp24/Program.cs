

using ConsoleApp24.Abstract;
using ConsoleApp24.Concretes;

Dialog webDialog = new WebDialog();
Dialog windowsDialog = new WindowsDialog();

webDialog.Render();
webDialog.CreateButton();



windowsDialog.Render();
windowsDialog.CreateButton();