using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        //public int NumberOfSongs { get; set; }

        public Artist Artist { get; set; }

        public Review Review { get; set; }
		
		
		
		
		
		
		
		
		
    }
}