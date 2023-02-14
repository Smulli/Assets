using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Poplloon.Entity;

    namespace Poplloon.Builder
    {
        public class BalloonBuilder
        {
            private BalloonColor _balloonColor;
            private Tail _tail;
            private BalloonConstructor _prefab;

            public BalloonBuilder WithColor(BalloonColor balloonColor)
            {
                _balloonColor = balloonColor;

                return this;
            }

            public BalloonBuilder WithTail(Tail tail)
            {
                _tail = tail;

                return this;
            }

            public BalloonBuilder FromBalloonPrefab(BalloonConstructor prefab)
            {
                _prefab = prefab;

                return this;
            }

            public BalloonConstructor Build()
            {
                Assert.IsNotNull(_prefab, "El prefab del balloon no puede ser nulo");

                var balloon = Object.Instantiate(_prefab);
                var balloonColor = Object.Instantiate(_balloonColor, balloon.transform, true);
                var tail = Object.Instantiate(_tail, balloonColor.transform, true);

                balloon.SetComponents(tail, balloonColor);

                return balloon;
            }
        }
    }

