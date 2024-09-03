using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Util
{
    public static Vector3 setX(Vector3 v, float x)
    {
        return new Vector3(x, v.y, v.z);
    }
    public static Vector3 setY(Vector3 v, float y)
    {
        return new Vector3(v.x, y, v.z);
    }
    public static Vector3 setZ(Vector3 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }
    public static Vector2 setX(Vector2 v, float x)
    {
        return new Vector2(x, v.y);
    }
    public static Vector2 setY(Vector2 v, float y)
    {
        return new Vector2(v.x, y);
    }
    public static Vector3 changeX(Vector3 v, float dx)
    {
        return new Vector3(v.x + dx, v.y, v.z);
    }
    public static Vector3 changeY(Vector3 v, float dy)
    {
        return new Vector3(v.x, v.y + dy, v.z);
    }
    public static Vector3 changeZ(Vector3 v, float dz)
    {
        return new Vector3(v.x, v.y, v.z + dz);
    }
    public static Vector2 changeX(Vector2 v, float dx)
    {
        return new Vector3(v.x + dx, v.y);
    }
    public static Vector2 changeY(Vector2 v, float dy)
    {
        return new Vector2(v.x, v.y + dy);
    }
}
