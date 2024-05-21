using System;

public interface IAlive : IInteracteble
{
    public event Action HasDead;

    public void TakeDamage(); 
}