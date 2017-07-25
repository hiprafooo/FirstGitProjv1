using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.DataLayer
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<UserGame> UserGames { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public virtual IDbSet<Game> Game { get; set; }
        public virtual IDbSet<UserGame> UserGame { get; set; }
    }

    public class Game
    {
        [Column("Game_Id")]
        public int Id { get; set; }
        public string GameName { get; set; }

        public virtual ICollection<UserGame> UserGames { get; set; }

    }

    public class UserGame
    {
        [Key]
        public int UserGameId { get; set; }

        [Column("User_Id")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Column("Game_Id")]
        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public virtual Game Game { get; set; }

        public TimeSpan HoursPlayed { get; set; }

    }
}
