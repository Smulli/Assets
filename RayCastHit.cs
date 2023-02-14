using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastHit : MonoBehaviour
{
    /*Ray _ray;
    RaycastHit _hit;
    public Balloon _balloon;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            Debug.DrawRay(_ray.origin, _ray.direction * 20, Color.red);

            if(Physics.Raycast(_ray, out _hit, Mathf.Infinity)){
                if(_hit.collider.tag == "Balloon")
                {
                    _balloon = GetComponent<Balloon>();
                    _balloon.DestroyBalloon();
                }
            }
        }
    }*/

}
