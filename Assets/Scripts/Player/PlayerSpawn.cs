using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private UISpawnsHealth _healthText;

    private void Start()
    {
        _healthText.ChangePlayerTextValue(_health);
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
        _healthText.ChangePlayerTextValue(_health);
        if (_health <= 0) Debug.Log("Lose");
    }
}
