using UnityEngine;

public class EnemyInterection : Unit
{
    public override IUnit UnitType { get;  set; }

    public override void Move()
    {
        UnitType.Move(Vector3.left);
    }

    private void EnemyAttackedSpawn(PlayerSpawn playerSpawn)
    {
        playerSpawn.TakeDamage(UnitType.GetAvailableHealth());
        gameObject.SetActive(false);
        UnitType.Heal();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerSpawn playerSpawn))
        {
            EnemyAttackedSpawn(playerSpawn);
        }
    }
}
