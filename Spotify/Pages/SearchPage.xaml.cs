using Spotify.Models;
using System.Collections.ObjectModel;

namespace Spotify;

public partial class SearchPage : ContentPage
{
    public ObservableCollection<Genres> Genres { get; private set; }
    public SearchPage()
	{
        InitializeComponent();
        CreateSongCollection();
        BindingContext = this;

    }
	void CreateSongCollection()
	{
        Genres = new ObservableCollection<Genres>();

        Genres.Add(new Genres
        {
            GenreName = "Hip Hop",
            GenreImage = "https://www.nationalflags.shop/WebRoot/vilkasfi01/Shops/2014080403/53F0/F886/BB3A/522C/CB5B/0A28/100A/2578/blue_rectangle.jpg"
        });
        Genres.Add(new Genres
        {
            GenreName = "Podcast",
            GenreImage = "https://dbdzm869oupei.cloudfront.net/img/vinylrugs/preview/38597.png"
        });
        Genres.Add(new Genres
        {
            GenreName = "Pop",
            GenreImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Orange_rectangle.svg/2560px-Orange_rectangle.svg.png"

        });
        Genres.Add(new Genres
        {
            GenreName = "Jazz",
            GenreImage = "https://htmlcolorcodes.com/assets/images/colors/dark-green-color-solid-background-1920x1080.png"

        });
        Genres.Add(new Genres
        {
            GenreName = "Local",
            GenreImage = "https://images.squarespace-cdn.com/content/v1/63064607eb816a4d50027fd1/d4c21413-0716-444a-839c-6de6b8650577/red-rectangle.jpg"

        });
        Genres.Add(new Genres
        {
            GenreName = "Party",
            GenreImage = "https://images.squarespace-cdn.com/content/v1/63064607eb816a4d50027fd1/6d44988f-0dcd-4f7a-ae84-b9e335baa728/teal-rectangle.jpg"

        });




    }
}