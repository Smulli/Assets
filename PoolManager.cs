using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poplloon.Pooler
{
    public enum Prefabs
    {
        Color,
        PowerUp,
        Cloud
    }

    [Serializable]
    public class PoolInfo
    {
        public Prefabs _type;
        public int _amout;
        public PoolAble _prefab;
        [HideInInspector]
        public List<PoolAble> _pool = new List<PoolAble>();
    }

    public class PoolManager : MonoBehaviour
    {
        [SerializeField] List<PoolInfo> _listOfPools = new List<PoolInfo>();
        public static PoolManager _pooler;

        private void Awake()
        {
            if(_pooler == null)
            {
                _pooler = this;
            }
            else { Destroy(gameObject); }
        }

        private void Start()
        {
            for(int i = 0; i < _listOfPools.Count; i++)
            {
                InitPool(_listOfPools[i]);
            }
        }

        public void InitPool(PoolInfo _info)
        {
            for(int i = 0; i < _info._amout; i++)
            {   
                PoolAble _instance = null;

                _instance = Instantiate(_info._prefab);
                _instance.gameObject.SetActive(false);
                _instance.transform.parent = transform;

                _info._pool.Add(_instance);
            }
        }
        public PoolAble GetObject(Prefabs _type)
        {
            PoolInfo _selected = GetObjectByType(_type);

            List<PoolAble> _instances = _selected._pool;

            PoolAble _instance = null;

            if(_instances.Count > 0)
            {
                _instance = _instances[_instances.Count - 1];
                _instances.Remove(_instance);
            }
            else { _instance = Instantiate(_selected._prefab); }

            return _instance;
        }

        public void Recycle(PoolAble _obj, Prefabs _type)
        {
            _obj.gameObject.SetActive(false);
            _obj.transform.position = Vector3.zero;
            _obj.transform.localScale = Vector3.one;

            PoolInfo _selected = GetObjectByType(_type);

            List<PoolAble> _instances = _selected._pool;

            if (!_instances.Contains(_obj))
            {
                _instances.Add(_obj);
            }
        }

        public PoolInfo GetObjectByType(Prefabs _type)
        {
            for(int i = 0; i < _listOfPools.Count; i++)
            {
                if(_type == _listOfPools[i]._type)
                {
                    return _listOfPools[i];
                }
            }

            return null;
        }
    }

}

