using UnityEngine;
using UnityEngine.UI;

public class UISpawnsHealth : MonoBehaviour
{
    [SerializeField] private Text _playerSpawnHealth;
    [SerializeField] private Text _enemySpawnHealth;

    public void ChangePlayerTextValue(int health)
    {
        _playerSpawnHealth.text = health.ToString();
    }
    public void ChangeEnemyTextValue(int health)
    {
        _enemySpawnHealth.text = health.ToString();
    }
}
