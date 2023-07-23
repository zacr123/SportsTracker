namespace WebSite.Models
{
    public class Sport
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int[] Points { get; set; }

        public static Sport[] GetSports() 
        {
            Sport[] sports = new Sport[3];

            Sport football = new Sport();
            football.Name = "Football";
            football.Image = "footballcarouselimage.jpg";
            football.Points = new int[1];
            football.Points[0] = 1;
            sports[0] = football;

            Sport rugby = new Sport();
            rugby.Name = "Rugby";
            rugby.Image = "rugbycarouselimage.jpg";
            rugby.Points = new int[3];
            rugby.Points[0] = 5;
            rugby.Points[1] = 2;
            rugby.Points[2] = 3;
            sports[1] = rugby;

            Sport netball = new Sport();
            netball.Name = "Netball";
            netball.Image = "netballcarouselimage.jpg";
            netball.Points = new int[1];
            netball.Points[0] = 1;
            sports[2] = netball;

            return sports;
        }
    }
}
