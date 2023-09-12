namespace Loginov_CatFramework;

public class CatException : ArgumentException
{
    public CatException(string str) : base($"{str}")
    { 
        
    }
}