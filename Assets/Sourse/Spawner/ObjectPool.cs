using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private GameObject _solderPrefab;
    [SerializeField] private int _capacity;

    private List<GameObject> _pool = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(_solderPrefab, _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    public bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.activeInHierarchy == false);

        return result != null;
    }
}