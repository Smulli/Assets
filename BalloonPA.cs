using Poplloon.Data;
using UnityEngine;
using Poplloon.Pooler;

namespace Poplloon.Entity
{
    public class BalloonPA : MonoBehaviour
    {
        public GameObject _model;
        public GameObject _tail;
        public GameObject _teddy;
        public bool _isTeddy;
        public Color _color;
        public Material[] _textures;
        public string _namePU;


        public void SetTail(MeshData _data)
        {
            MeshData.SetMeshData(_data._mesh, _data._material, _tail.GetComponent<Renderer>(), _tail.GetComponent<MeshFilter>());

            if (_data.GetName() == "Ribbon")
            {
                _teddy.SetActive(true);
            }

            else { _teddy.SetActive(false); }
        }

        public void SetTeddy(MeshData _data)
        {
            MeshData.SetMeshData(_data._mesh, _data._material, _teddy.GetComponent<Renderer>(), _teddy.GetComponent<MeshFilter>());
        }

        public void SetColor(Color _colorData)
        {
            _model.transform.GetChild(0).GetComponent<Renderer>().material.color = _colorData;

            _color = _colorData;
        }
    }
}


    

    

