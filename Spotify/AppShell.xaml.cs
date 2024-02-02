using Spotify.Pages;

namespace Spotify
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        void RegisterRoutes()
        {
            Routing.RegisterRoute("Home", typeof(MainPage));
            Routing.RegisterRoute("Search", typeof(SearchPage));
            Routing.RegisterRoute("Library", typeof(LibraryPage));

        }
    }
}
