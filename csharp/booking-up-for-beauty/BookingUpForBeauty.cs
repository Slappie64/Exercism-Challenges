using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
    }

    public static string Description(DateTime appointmentDate)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
    }

    public static DateTime AnniversaryDate()
    {
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
