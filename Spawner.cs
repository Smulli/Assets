using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Pooler;
using Poplloon.Entity;
using Poplloon.Attributes;

public class Spawner : MonoBehaviour
{
    private float _spawnColor = 0.7f;
    private float _spawnPower = 5f;

    void Update()
    {
        _spawnColor -= Time.deltaTime;
        _spawnPower -= Time.deltaTime;

        if(_spawnColor < 0f)
        {
            StartCoroutine(SpawnColor(Prefabs.Color));

            _spawnColor = 0.7f;
        }

        if(_spawnPower < 0f)
        {
            StartCoroutine(SpawnPower(Prefabs.PowerUp));

            _spawnPower = 5f;
        }
    }

    private IEnumerator SpawnColor(Prefabs _type)
    {
        BalloonPA _obj = PoolManager._pooler.GetObject(_type) as BalloonPA;

        //Set random color and mesh data
        _obj.Init();
        _obj.SetColor(GameManager.Instance._colorBlind.GetColor());
        _obj.SetTail(GameManager.Instance._tailSet.GetRandomMesh());
        _obj.SetTeddy(GameManager.Instance._teddySet.GetRandomMesh());

        yield return new WaitForSeconds(8f);

        PoolManager._pooler.Recycle(_obj, _type);
    }

    private IEnumerator SpawnPower(Prefabs _type)
    {
        PowerPA _pbj = PoolManager._pooler.GetObject(_type) as PowerPA;

        _pbj.Init();
        _pbj.SetPower(GameManager.Instance.GetRandomPower());

        yield return new WaitForSeconds(8f);

        PoolManager._pooler.Recycle(_pbj, _type);
    }
}
