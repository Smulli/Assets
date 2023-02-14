using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Builder;
using Poplloon.Factory;

namespace Poplloon.Entity
{
    public class BalloonColor : BalloonController
    {
        [SerializeField] private GameObject _model;
        //[SerializeField] private GameObject _teddy;

        [Space]
        public Color _color;

        [Space]
        public bool _isTeddy;

        private void Awake()
        {
            //BalloonConsumer._consumer.Init();
        }

        public void SetColor(Color colorData)
        {
            _model.transform.GetChild(0).GetComponent<Renderer>().sharedMaterial.color = colorData;
        }

        /*public GameObject _model;
        protected Color _color;

        public void SetColor(Color colorData)
        {
            _model.transform.GetChild(0).GetComponent<Renderer>().sharedMaterial.color = colorData;
        }*/
    }
}
