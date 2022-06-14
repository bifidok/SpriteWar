using System.Collections.Generic;
using UnityEngine;

public class Pool<T> where T : MonoBehaviour
{
    private int _unitsCount;
    private Transform _container;
    private int _units;
    private T[] _prefabs;
    private List<T> _pool;

    public Pool(int count, int units, T[] prefabs, Transform container)
    {
        _container = container;
        _unitsCount = count;
        _prefabs = prefabs;
        _units = units;
    }

    public void Init()
    {
        CreatePool();
    }

    private void CreatePool()
    {
        _pool = new List<T>();

        for (int i = 0; i < _units; i++)
        {
            for (int j = 0; j < _unitsCount; j++)
            {
                _pool.Add(CreateObject(_prefabs[i]));

            }
        }

    }

    private T CreateObject(T unitPrefab)
    {
        var unit = GameObject.Instantiate(unitPrefab, _container);
        unit.gameObject.SetActive(false);
        return unit;
    }


    private T CreateNewObject(T newUnit)
    {
        var unit = GameObject.Instantiate(newUnit, _container);
        _pool.Add(unit);
        unit.gameObject.SetActive(true);
        return unit;
    }
    public T GetFreeOrNewElement(T element, int elementNumber)
    {
        foreach (var unit in _pool)
        {
            int unitNumber = unit.GetComponent<UnitController>().UnitNumber - 1;
            if (!unit.gameObject.activeInHierarchy && elementNumber == unitNumber)
            {
                element = unit;
                element.gameObject.SetActive(true);
                return element;
            }
        }
        return CreateNewObject(element);
    }
}
