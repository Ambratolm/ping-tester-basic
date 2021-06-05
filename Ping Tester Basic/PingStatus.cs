using System.Drawing;

namespace PingTesterBasic
{
    public class PingStatus
    {
        public string Message { get; set; }
        public long Time { get; set; }
        public string TimeString 
        { 
            get 
            {
                return (this.Time >= 0) 
                    ? string.Format("{0} ms", this.Time) : string.Empty;
            }
        }
        public Color Color { get; set; }

        public PingStatus(long time)
        {
            this.Time = time;
            if (this.Time < 0)
            {
                this.Message = "Disconnected";
                this.Color = Color.Silver;
            }
            else if (this.Time >= 0 && this.Time <= 99)
            {
                this.Message = "Good";
                this.Color = Color.Green;
            }
            else if (this.Time >= 100 && this.Time <= 299)
            {
                this.Message = "Medium";
                this.Color = Color.Orange;
            }
            else
            {
                this.Message = "Bad";
                this.Color = Color.Red;
            }
        }
    }
}
