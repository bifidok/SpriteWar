using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareUnit : IUnit
{
    private int _startHealth;
    private int _health;
    private Rigidbody2D _rigidbody;
    private int _speed;

    public SquareUnit(Rigidbody2D rigidbody, int speed, int startHealth)
    {
        _rigidbody = rigidbody;
        _speed = speed;
        _startHealth = startHealth;
        _health = startHealth;
    }

    public void Heal()
    {
        _health = _startHealth;
    }
    public int GetAvailableHealth()
    {
        return _health;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public void Move(Vector3 direction)
    {
        _rigidbody.velocity = direction * _speed;
    }
}
