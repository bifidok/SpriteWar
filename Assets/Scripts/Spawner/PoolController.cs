using UnityEngine;

public class PoolController : MonoBehaviour
{
    [SerializeField] private int _startCount = 3;
    [SerializeField] private UnitController[] _units;
    [SerializeField] private UnitController[] _enemyUnits;

    [Header("Player Pool")]
    [SerializeField] private Transform _playerContainer;

    [Header("EnemyPool")]
    [SerializeField] private Transform _enemyContainer;

    private Pool<UnitController> _playerPool;
    private Pool<UnitController> _enemyPool;

    private void Start()
    {
        _playerPool = new Pool<UnitController>(_startCount,_units.Length, _units, _playerContainer);
        _enemyPool = new Pool<UnitController>(_startCount, _enemyUnits.Length, _enemyUnits, _enemyContainer);
        _enemyPool.Init();
        _playerPool.Init();
    }

    public void GetPlayerUnit(int unitNumber)
    {
        var unit = _playerPool.GetFreeOrNewElement(_units[unitNumber], unitNumber);
        unit.transform.position = _playerContainer.transform.position;
    }

    public void GetEnemyUnit(int unitNumber)
    {
        var enemyUnit = _enemyPool.GetFreeOrNewElement(_enemyUnits[unitNumber], unitNumber);
        enemyUnit.transform.position = _enemyContainer.transform.position;
    }
}
