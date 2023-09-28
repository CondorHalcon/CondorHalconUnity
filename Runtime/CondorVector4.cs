using UnityEngine;

public class CondorVector4
{
    public float x { get; private set; }
    public float y { get; private set; }
    public float z { get; private set; }
    public float w { get; private set; }

    public CondorVector4(Vector4 vector)
    {
        this.x = vector.x;
        this.y = vector.y;
        this.z = vector.z;
        this.w = vector.w;
    }

    // implicit convertions
    public static implicit operator CondorVector4(Vector4 vector)
    {
        return new CondorVector4(vector);
    }
    public static implicit operator Vector4(CondorVector4 vector)
    {
        return new Vector4(vector.x, vector.y, vector.z, vector.w);
    }

    // Addition Operator: +
    // Adds to the magnitude of the vector
    public static Vector4 operator +(CondorVector4 lhs, float rhs)
    {
        return (Vector4)lhs + (((Vector4)lhs).normalized * rhs);
    }
    // Subtraction Operator: -
    // Subtracts from the magnitude of the vector
    public static Vector4 operator -(CondorVector4 lhs, float rhs)
    {
        return (Vector4)lhs - (((Vector4)lhs).normalized * rhs);
    }
    // Exponent Operator: ^
    public static Vector4 operator ^(CondorVector4 lhs, float rhs)
    {
        return new Vector4(Mathf.Pow(lhs.x, rhs), Mathf.Pow(lhs.y, rhs), Mathf.Pow(lhs.z, rhs), Mathf.Pow(lhs.w, rhs));
    }
}