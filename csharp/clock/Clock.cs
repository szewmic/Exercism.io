using System;

public class Clock : IEquatable<Clock>
{
    public int Hours { get; private set; }

    public int Minutes { get; private set; }
    public Clock(int hours, int minutes)
    {

        int hoursFromMin = minutes / 60;
        int clockMinute = minutes - hoursFromMin * 60;

        int clockHourFromHours = hours / 24;
        int clockHour = hours - clockHourFromHours * 24 + (hoursFromMin - (hoursFromMin/24)*24);

        if (clockMinute < 0)
        {
            clockHour--;
            if (clockHour < 0) clockHour += 24;
            int restMinutes = clockMinute / 60;
            clockMinute = 60 + clockMinute - restMinutes;
        }

        Minutes = clockMinute;
        Hours = clockHour;

        if (Hours < 0) Hours = 24 + Hours;
    }

    public Clock Add(int minutesToAdd) => new Clock(0, this.Hours * 60 + this.Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(0, this.Hours * 60 + this.Minutes - minutesToSubtract);

    public override string ToString()
    {
        var strHour = ""+Hours;
        var strMin = ""+Minutes;

        if (Hours < 10)
            strHour = "0" + strHour;

        if (Minutes < 10)
            strMin = "0" + strMin;

        return $"{strHour}:{strMin}";
    }

    public bool Equals(Clock other)
    {
        return other.Hours == this.Hours && other.Minutes == this.Minutes ? true : false;
    }
}