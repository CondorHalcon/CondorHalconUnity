using UnityEngine;

public class CondorFloat
{
    public float value { get; private set; }

    public CondorFloat(float n)
    {
        this.value = n;
    }

    // implicit convertions
    public static implicit operator CondorFloat(float f)
    {
        return new CondorFloat(f);
    }
    public static implicit operator float(CondorFloat f)
    {
        return f.value;
    }

    // Exponent Operator: ^
    public static float operator ^(CondorFloat lhs, float rhs)

    {
        return Mathf.Pow(lhs.value, rhs);
    }
    public static int operator ^(CondorFloat lhs, int rhs)
    {
        return (int)Mathf.Pow(lhs.value, rhs);
    }
}
