using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Entity;

namespace Poplloon.Builder
{
    public class BalloonConsumer : MonoBehaviour
    {
        public static BalloonConsumer _consumer;

        [Space]
        [Header("Balloon to build")]
        [SerializeField] private BalloonColor _balloonColor;

        [Space]
        [Header("Tail types")]
        [SerializeField] private Tail[] _tails;

        [Space]
        [Header("Preab Constructor")]
        [SerializeField] private BalloonConstructor _prefab;

        [Space]
        private BalloonBuilder _builder;
        private BalloonConstructor _balloonInstance;

        public void Init()
        {
            _builder = new BalloonBuilder();
            _builder.FromBalloonPrefab(_prefab);

            BuildColor();
            BuildTail();
            Building();
        }

        public void Building()
        {
            _builder.Build();
        }

        public void BuildColor()
        {
            _builder.WithColor(_balloonColor);

            _balloonColor.SetColor(GameManager.Instance._colorBlind.GetColor());
        }

        public void BuildTail()
        {
            int index = Random.Range(0, _tails.Length);

            _builder.WithTail(_tails[index]);
        }
    }
}
