using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public abstract IUnit UnitType { get; set; }
    private IUnit[] _unitTypes;
    public void Init(int speed, int unitNumber)
    {
        if (UnitType == null)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            _unitTypes = new IUnit[] { new SquareUnit(rigidbody, speed, unitNumber), new CircleUnit(rigidbody, speed, unitNumber),
                new HexagonUnit(rigidbody,speed, unitNumber) };
            SetUnitType(unitNumber);
        }
    }

    private void SetUnitType(int unitNumber)
    {
        UnitType = _unitTypes[unitNumber - 1]; 
    }

    public abstract void Move();

}
