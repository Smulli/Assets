using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Pooler;

namespace Poplloon.Entity
{
    public class BalloonController : PoolAble
    {
        public float _offset;
        public bool _isMoving;

        public override void Init()
        {
            float xPos = Random.Range(-0.1f, 0.1f);

            gameObject.transform.localScale = Vector3.one * Random.Range(2, 7);
            gameObject.transform.position = new Vector3(xPos, -10f, -7f);
            gameObject.SetActive(true);
        }

        private void Start()
        {
           _isMoving = true;
           _offset = UnityEngine.Random.Range(0f, 1f);
        }

        void Update()
        {
            if (_isMoving)
            {
                Vector3 _dir = Vector3.up;
                float _speed = 1.5f * Time.deltaTime;

                transform.Translate(_dir * _speed + Vector3.right * (Mathf.Sin(Time.time + _offset) / 1200));
            }
        }
    }
}

