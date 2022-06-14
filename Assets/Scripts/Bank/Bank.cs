
public class Bank 
{
    public int Money { get; private set; }
    private int _moneyAddWithDelayValue;
    public Bank(int money, int moneyAddWithDelay)
    {
        Money = money;
        _moneyAddWithDelayValue = moneyAddWithDelay;
    }

    public bool HasMoney(int unitCost)
    {
        if (Money >= unitCost)
        {
            ReduceMoney(unitCost);
            return true;
        }
        return false;
    }


    public void AddMoneyWithDelay()
    {
        Money += _moneyAddWithDelayValue;
    }
    private void ReduceMoney(int unitCost)
    {
        Money -= unitCost;
    }
}
