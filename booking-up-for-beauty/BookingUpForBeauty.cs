using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate)
    {
        DateTime now  = DateTime.Now;
        return DateTime.Compare(appointmentDate, now) < 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {   
        int hour = appointmentDate.Hour;
        return hour >= 12 && hour < 18;
    }

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.Date.ToString("d")} {appointmentDate.ToLongTimeString()}.";
    
    public static DateTime AnniversaryDate()
    {
        int currentYear = DateTime.Now.Year;
        return new DateTime(currentYear, 9, 15);
    }
}
