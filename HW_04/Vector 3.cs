struct Vector3
{
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Add(Vector3 vector)
    {
        X += vector.X;
        Y += vector.Y;
        Z += vector.Z;
    
    }

    public float Distance(Vector3 vector)
    {
        float offsetX = offsetX = X - vector.X;
        float offsetY = offsetY= Y - vector.Y;
        float offsetZ = offsetZ = Z - vector.Z;
        return (float)System.Math.Sqrt(offsetX * offsetX + offsetY * offsetY + offsetZ * offsetZ);

    }

}