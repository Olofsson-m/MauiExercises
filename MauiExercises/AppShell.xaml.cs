using System.Security.Cryptography.X509Certificates;
using MauiExercises.Models;
using MauiExercises.Views.Lesson05;
using Microsoft.Maui;

namespace MauiExercises;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        //Exercise ShellMenu: Adding an item to a Shell Menu in C#
        var NewsPapers = NewsSource.All;
        foreach (var item in NewsPapers)
        {
            //Create a Tab, set its relevant properties
            //Your code

            //Create a ShellContent , set its relevant properties
            //Your code
            lesson5news2.Items.Add( new ShellContent
            {
                Title = item.Name,
                Route = $"WebViewExplore_{item.Name}",   
                ContentTemplate = new DataTemplate(() => new WebViewExplore(item))
            });          
            //Add the ShellContent into the Tab
            //Your code

            //Add the Tab into lesson5news2 flyout item from the Xaml page
            //Your code
        }
    }
}
