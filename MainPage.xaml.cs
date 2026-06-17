using MusciApp.ViewModels;

namespace MusciApp;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel _viewModel;

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.SetMediaElement(audioPlayer);
    }

    private void OnSeekDragCompleted(object? sender, EventArgs e)
    {
        if (sender is Slider slider && BindingContext is MainViewModel vm)
        {
            vm.SeekCommand.Execute(slider.Value);
        }
    }
}