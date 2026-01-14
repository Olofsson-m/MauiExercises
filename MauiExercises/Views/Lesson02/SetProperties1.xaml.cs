using MauiExercises.Models;

namespace MauiExercises.Views.Lesson02;


public partial class SetProperties1 : ContentPage
{
	int _idx = 0;
	List<NamedColor> _colors = NamedColor.All.ToList();

	public SetProperties1()
	{
		InitializeComponent();
    }

	private void Button_Clicked(object sender, EventArgs a)
	{
		_idx++;
		if (_idx >= _colors.Count)
			_idx = 0;
		var color = _colors[_idx].Color;
		lblColorBox.BackgroundColor = color;
		
	}
}