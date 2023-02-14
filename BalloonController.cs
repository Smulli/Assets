using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Utilities;
using Poplloon.Builder;

namespace Poplloon.Factory
{
    public abstract class BalloonController : RecyclableObject
    {
        [SerializeField] private int _index;

        public int Index => _index;

        private void Update()
        {
            if(transform.position.y > 10f)
            {
                Recycle();
            }
        }

        internal override void Init()
        {
        }

        internal override void Release()
        {
        }
    }
}
