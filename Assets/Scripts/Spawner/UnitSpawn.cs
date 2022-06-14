using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    [SerializeField] private UIButtons _uiButtons;
    [SerializeField] private BankController _bankController;
    [SerializeField] private PoolController _pool;

    private void OnEnable()
    {
        _uiButtons.buttonClicked += SpawnUnits;
    }

    private void OnDisable()
    {
        _uiButtons.buttonClicked -= SpawnUnits;
    }

    private void SpawnUnits(int unitNumber)
    {
        if(_bankController.HasMoney((unitNumber + 1) * 10))
        {
            _pool.GetPlayerUnit(unitNumber);
        }
    }
}
