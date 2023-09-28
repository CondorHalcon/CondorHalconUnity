using UnityEngine;

public class CondorVector3
{
    public float x { get; private set; }
    public float y { get; private set; }
    public float z { get; private set; }

    public CondorVector3(Vector3 vector)
    {
        this.x = vector.x;
        this.y = vector.y;
        this.z = vector.z;
    }

    // implicit convertions
    public static implicit operator CondorVector3(Vector3 vector)
    {
        return new CondorVector3(vector);
    }
    public static implicit operator Vector3(CondorVector3 vector)
    {
        return new Vector3(vector.x, vector.y, vector.z);
    }

    // Addition Operator: +
    // Adds to the magnitude of the vector
    public static Vector3 operator +(CondorVector3 lhs, float rhs)
    {
        return (Vector3)lhs + (((Vector3)lhs).normalized * rhs);
    }
    // Subtraction Operator: -
    // Subtracts from the magnitude of the vector
    public static Vector3 operator -(CondorVector3 lhs, float rhs)
    {
        return (Vector3)lhs - (((Vector3)lhs).normalized * rhs);
    }
    // Exponent Operator: ^
    public static Vector3 operator ^(CondorVector3 lhs, float rhs)
    {
        return new Vector3(Mathf.Pow(lhs.x, rhs), Mathf.Pow(lhs.y, rhs), Mathf.Pow(lhs.z, rhs));
    }
}