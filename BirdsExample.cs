public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins cannot fly.");
    }
}

public void MakeBirdFly(Bird bird)
{
    bird.Fly();
}
