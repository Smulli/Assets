using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Attributes;
using Poplloon.Entity;

public class PowerPA : MonoBehaviour
{
    [SerializeField] private GameObject _model;
    [SerializeField] private Material[] _textures;
    public string _name;

    private PowerUpCollection.PowerUpSets _power { get; set; }

    public void SetPower(PowerUpCollection.PowerUpSets power)
    {
        _power = power;

        Renderer _renderer = _model.GetComponent<Renderer>();

        switch (power)
        {
            case
                PowerUpCollection.PowerUpSets.Vulnerable:
                {
                    _renderer.material = _textures[0];
                    gameObject.tag = "Vulnerable";
                }
                break;
            case
                PowerUpCollection.PowerUpSets.Multiplied:
                {
                    _renderer.material = _textures[1];
                    gameObject.tag = "Multiplied";
                }
                break;
            case
                PowerUpCollection.PowerUpSets.Bomb:
                {
                    _renderer.material = _textures[2];
                    gameObject.tag = "Bomb";
                }
                break;

        }
    }

    public string GetName() => _name;

    public IEnumerator IsVulnerable()
    {
        GameManager.Instance._isVulnerable = false;

        yield return new WaitForSeconds(5f);
    }
}