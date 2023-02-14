using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Pooler;

public class PoolAble : MonoBehaviour
{
    public PoolManager pool;

    public virtual void Init()
    {
        gameObject.SetActive(true);
    }

    public virtual void Release()
    {
        gameObject.SetActive(false);
    }
}
