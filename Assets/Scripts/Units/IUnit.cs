using UnityEngine;

public interface IUnit
{
    void Move(Vector3 direction);
    void Heal();
    void TakeDamage(int damage);
    int GetAvailableHealth();

}
