using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Poplloon.Entity;

namespace Poplloon.Builder
{
    public class BalloonConstructor : MonoBehaviour
    {
        private Tail _tail;
        private BalloonColor _balloon;

        public void SetComponents(Tail tail, BalloonColor balloon)
        {
            _tail = tail;
            _balloon = balloon;
        }
    }
}

