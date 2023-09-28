using UnityEngine;

public class CondorVector2
{
    public float x { get; private set; }
    public float y { get; private set; }

    public CondorVector2(Vector2 vector)
    {
        this.x = vector.x;
        this.y = vector.y;
    }

    // implicit convertions
    public static implicit operator CondorVector2(Vector2 vector)
    {
        return new CondorVector2(vector);
    }
    public static implicit operator Vector2(CondorVector2 vector)
    {
        return new Vector2(vector.x, vector.y);
    }

    // Addition Operator: +
    // Adds to the magnitude of the vector
    public static Vector2 operator +(CondorVector2 lhs, float rhs)
    {
        return (Vector2)lhs + (((Vector2)lhs).normalized * rhs);
    }
    // Subtraction Operator: -
    // Subtracts from the magnitude of the vector
    public static Vector2 operator -(CondorVector2 lhs, float rhs)
    {
        return (Vector2)lhs - (((Vector2)lhs).normalized * rhs);
    }
    // Exponent Operator: ^
    public static Vector2 operator ^(CondorVector2 lhs, float rhs)
    {
        return new Vector2(Mathf.Pow(lhs.x, rhs), Mathf.Pow(lhs.y, rhs));
    }
}