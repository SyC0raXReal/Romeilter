namespace Romeilter.Models;

public interface ICurrency
{
    Currency Currency { get; set; }
    decimal Cost { get; set; }
}