using UnityEngine;
using UnityEngine.Events;

public class BankController : MonoBehaviour
{
    [SerializeField] private int _startMoney;
    [SerializeField] private int _delay;
    [SerializeField] private int _addMoneyWithDelayValue;
    [SerializeField] private UIMoney _uiMoney;
    public int StartMoney { get { return _startMoney; } }
    private float _delayTimer;
    private Bank _bank;


    private void Start()
    {
        _bank = new Bank(_startMoney, _addMoneyWithDelayValue);
        _uiMoney.ChangeValue(_startMoney);
        _delayTimer = _delay;
    }

    private void Update()
    {
        if(_delayTimer <= 0 )
        {
            _bank.AddMoneyWithDelay();
            _uiMoney.ChangeValue(_bank.Money);
            _delayTimer = _delay;
        }
        _delayTimer -= Time.deltaTime;

    }

    public bool HasMoney(int unitCost)
    {
        if(_bank.HasMoney(unitCost))
        {
            _uiMoney.ChangeValue(_bank.Money);
            return true;
        }

        return false;
    }
}
