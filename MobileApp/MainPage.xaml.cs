namespace MobileApp;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;


public partial class MainPage : ContentPage
{
    private int clickCount;
    private Image image;
    private Label helloLabel;
    private Label welcomeLabel;
    private Button counterButton;

    public MainPage()
	{
        clickCount = 0;

        //CHANGE BACKGROUND COLOR HERE
        BackgroundColor = Colors.Black;

        image = new Image
        {
            Source = new UriImageSource
            {
                //CHANCE PICTRE HERE
                Uri = new Uri("https://media.tenor.com/SSY2V0RrU3IAAAAd/rick-roll-rick-rolled.gif"),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(5),

            },

            //CHANGE WIDTH AND HEIGHT HERE
            HeightRequest = 200,
            WidthRequest = 200,
            HorizontalOptions = LayoutOptions.Center,
            IsAnimationPlaying = true
        };

        helloLabel = new Label
        {
            //CHANGE TITLE HERE
            Text = "Hello, World!",

            //CHANGE TITLE SIZE HERE
            FontSize = 32,
            HorizontalOptions = LayoutOptions.Center
        };

        welcomeLabel = new Label
        {
            Text = "Welcome to .NET Multi-platform App UI",
            FontSize = 18,
            HorizontalOptions = LayoutOptions.Center
        };

        counterButton = new Button
        {
            Text = "Click me",
            HorizontalOptions = LayoutOptions.Center
        };
        counterButton.Clicked += OnCounterClicked;

        var stackLayout = new StackLayout
        {
            Spacing = 25,
            Padding = new Thickness(30, 0),
            VerticalOptions = LayoutOptions.Center
        };
        stackLayout.Children.Add(image);
        stackLayout.Children.Add(helloLabel);
        stackLayout.Children.Add(welcomeLabel);
        stackLayout.Children.Add(counterButton);

        Content = new ScrollView
        {
            Content = stackLayout
        };

        

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        clickCount++;
        counterButton.Text = $"Clicked: {clickCount} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

