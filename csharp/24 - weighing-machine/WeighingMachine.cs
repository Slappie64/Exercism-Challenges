using System;

class WeighingMachine
{

    
    public WeighingMachine(double precision) => Precision = precision;
    

    public double Precision { get; }

    private double _weight;
    public double Weight 
    {
        get { return _weight; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _weight = value;
            }
        }
    }
    public string DisplayWeight 
    { 
        get { return string.Format(string.Concat("{0:F", Precision, "} kg"), Weight - TareAdjustment); }
    }
    public double TareAdjustment { get; set;} = 5;

}
