using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Util;
public class PoolManager : Singleton<PoolManager>
{

    #region Public Fields

    #endregion


    #region Private Fields
    [SerializeField]
    private int maxSize = 100;
    private Stack<GameObject> pool = null;
    private Dictionary<GameObject, Stack<GameObject>> pools;
    #endregion


    #region Accessors

    #endregion


    #region MonoBehaviour Methods
    private new void Awake()
    {
        base.Awake();
        pools = new Dictionary<GameObject, Stack<GameObject>>();
    }
    #endregion


    #region Private Methods
    #endregion


    #region Public Methods
    public GameObject Get(GameObject _prefab)
    {
        if (pools.TryGetValue(_prefab, out pool))
        {
            if (pool.Count > 0)
            {
                GameObject go = pool.Pop();
                go.SetActive(true);
                return go;
            }
        }
        return null;
    }

    public void Add(GameObject _prefab, GameObject _gameObject)
    {
        if (pools.TryGetValue(_prefab, out pool))
        {
            if (pool.Count < maxSize)
            {
                _gameObject.SetActive(false);
                pool.Push(_gameObject);
            }
            else Destroy(_gameObject);
        }
        else
        {
            Stack<GameObject> pool = new Stack<GameObject>();
            _gameObject.SetActive(false);
            pool.Push(_gameObject);
            pools.Add(_prefab, pool);
        }
    }
    #endregion


}
