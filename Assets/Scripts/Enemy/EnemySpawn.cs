using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private PoolController _pool;
    [SerializeField] private Vector2 _unitsNumberRange;
    [SerializeField] private Vector2 _unitSpawnDelayRange;
    [SerializeField] private UISpawnsHealth _healthText;
    [SerializeField] private int _health;

    private void Start()
    {
        _healthText.ChangeEnemyTextValue(_health);
        StartCoroutine(UnitSpawner());
    }
    private IEnumerator UnitSpawner()
    {
        while (true)
        {
            _pool.GetEnemyUnit(Random.Range((int)_unitsNumberRange.x - 1,(int)_unitsNumberRange.y));
            yield return new WaitForSeconds(Random.Range(_unitSpawnDelayRange.x, _unitSpawnDelayRange.y));
        }
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
        _healthText.ChangeEnemyTextValue(_health);
        if (_health <= 0) Debug.Log("Win");
    }
}
