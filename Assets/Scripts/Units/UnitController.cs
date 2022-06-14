using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class UnitController : MonoBehaviour
{
    public int UnitNumber => _unitNumber;

    [SerializeField] private Unit _unit;
    [SerializeField] private int _unitNumber;
    [SerializeField] private int _speed;

    private void OnEnable()
    {
        _unit.Init(_speed, _unitNumber);

    }

    private void OnDisable()
    {
        transform.localPosition = new Vector3(0, 0, 0);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            _unit.Move();
        }
    }
}
