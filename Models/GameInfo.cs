using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Models
{
    public class GameInfo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string GameType { get; set; }

    public string CompanyName { get; set; }

    public string Genre { get; set; }

    public int AgeRestriction { get; set; }

    public string Desription { get; set; }

    public string Image { get; set; }

    public DateTime YearPublished { get; set; }
}
}
