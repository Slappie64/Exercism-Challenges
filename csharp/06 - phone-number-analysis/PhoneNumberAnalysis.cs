using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string phoneNumberFirst = phoneNumber.Split("-")[0];
        string phoneNumberSecond = phoneNumber.Split("-")[1];
        string phoneNumberThird = phoneNumber.Split("-")[2];

        return (phoneNumberFirst == "212", phoneNumberSecond == "555", phoneNumberThird);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;

}
