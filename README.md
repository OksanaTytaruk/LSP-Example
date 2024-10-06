# LSP Example (Liskov Substitution Principle)

Цей репозиторій містить приклад принципу підстановки Лісков з SOLID.

## Принцип підстановки Лісков (LSP)

Об'єкти базового класу мають бути замінними на об'єкти похідного класу без порушення коректності програми.

### Приклад коду:

```csharp
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
