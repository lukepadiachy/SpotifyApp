
using Spotify.NewFolder;

namespace Spotify
{
    public partial class MainPage : ContentPage
    {
        public IList<Songs> Songs { get; private set; }
        public IList<SecondRowSongs> SecondRowSongs { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            CreateSongCollection();
            CreateSecondSongCollection(); 
            BindingContext = this;
        }

        void CreateSongCollection()
        {
            Songs = new List<Songs>();

            Songs.Add(new Songs
            {
                Name = "Its Not That Deep",
                ImageUrl = "https://is1-ssl.mzstatic.com/image/thumb/Music122/v4/08/1b/ac/081bacb8-3495-119f-c555-c2f042b6e3bd/artwork.jpg/1200x1200bf-60.jpg"
            });
            Songs.Add(new Songs
            {
                Name = "Movin Different",
                ImageUrl = "https://source.boomplaymusic.com/group10/M00/10/14/e4718bf808cb4eafa2b2fdb5b9476b8e_464_464.jpg"
            });
            Songs.Add(new Songs
            {
                Name = "Deeper Than Rap ",
                ImageUrl = "https://p16-tm-sg.tiktokmusic.me/img/tos-alisg-v-2102/625594462fe14489a8f9747a9c4418ae~c5_500x500.jpg"
            });
            Songs.Add(new Songs
            {
                Name = "Meraki",
                ImageUrl = "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/7c/87/86/7c8786ea-dda1-5c0f-15fe-46f2e3ff7d69/artwork.jpg/1200x1200bf-60.jpg"
            });
            Songs.Add(new Songs
            {
                Name = "I Dont Think You Really Do ",
                ImageUrl = "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/30/6d/27/306d27a2-9ff0-4d72-6017-ef6e7032b4fa/artwork.jpg/316x316bf.webp"
            });
        }

        void CreateSecondSongCollection()
        {
            SecondRowSongs = new List<SecondRowSongs>();

            SecondRowSongs.Add(new SecondRowSongs
            {
                NameTwo = "Been A Minute",
                ImageTwo = "https://m.media-amazon.com/images/I/51UprbjvkrL._UXNaN_FMjpg_QL85_.jpg"
            });
            
            SecondRowSongs.Add(new SecondRowSongs
            {
                NameTwo = "Mercy Mercy Me",
                ImageTwo = "https://is1-ssl.mzstatic.com/image/thumb/Music112/v4/68/4a/23/684a2359-036a-fccf-dde2-95d13f87c0ba/artwork.jpg/316x316bf.webp"

            });
            SecondRowSongs.Add(new SecondRowSongs
            {
                NameTwo = "Mind Over Matter",
                ImageTwo = "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/f3/09/d1/f309d1bd-540e-d80d-9a09-ff5ac120828f/artwork.jpg/316x316bf.webp"

            });
            SecondRowSongs.Add(new SecondRowSongs
            {
                NameTwo = "Can't Let EM In",
                ImageTwo = "https://is1-ssl.mzstatic.com/image/thumb/Music122/v4/62/7a/29/627a2963-bde7-5b19-469b-fe090341e2b6/artwork.jpg/316x316bf.webp"

            });
            SecondRowSongs.Add(new SecondRowSongs
            {
                NameTwo = "CYAN",
                ImageTwo = "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/66/80/0b/66800bd0-e4bd-5cf2-9a8e-9123c495ff03/artwork.jpg/316x316bb.webp"

            });

        }
    }
}
