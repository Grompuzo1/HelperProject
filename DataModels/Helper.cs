namespace tyuiu.oop.ZhukovDA.IsakovAV.StudentHelper.DataModels
{
    public class Helper
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Duration { get; set; }

        public void SetDateWithDaysAhead(int daysAhead)
        {
            Duration = DateTime.Now.AddDays(daysAhead);
        }
    }
}
