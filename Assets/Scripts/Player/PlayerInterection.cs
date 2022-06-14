using UnityEngine;

public class PlayerInterection : Unit
{
    public override IUnit UnitType { get;  set; }

    private void PlayerAttackedEnemy(EnemyInterection enemy)
    {
        var playerHealth = UnitType.GetAvailableHealth();
        var enemyHealth = enemy.UnitType.GetAvailableHealth();

        UnitType.TakeDamage(enemyHealth);
        if (UnitType.GetAvailableHealth() <= 0)
        {
            gameObject.SetActive(false);
            UnitType.Heal();
        }

        enemy.UnitType.TakeDamage(playerHealth);
        if (enemy.UnitType.GetAvailableHealth() <= 0)
        {
            enemy.gameObject.SetActive(false);
            enemy.UnitType.Heal();
        }
    }

    private void PlayerAttackedSpawn(EnemySpawn enemySpawn)
    {
        enemySpawn.TakeDamage(UnitType.GetAvailableHealth());
        gameObject.SetActive(false);
        UnitType.Heal();
    }

    public override void Move()
    {
        UnitType.Move(Vector3.right);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyInterection enemy))
        {
            PlayerAttackedEnemy(enemy);
        }

        if (collision.gameObject.TryGetComponent(out EnemySpawn enemySpawn))
        {
            PlayerAttackedSpawn(enemySpawn);
        }
    }
}
