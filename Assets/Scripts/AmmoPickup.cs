using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    [SerializeField] int ammoAmmount = 5;
    [SerializeField] AmmoType ammoType;

    Ammo ammo;

    private void Start()
    {
        ammo = FindObjectOfType<Ammo>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ammo.IncreaseCurrentAmmo(ammoType, ammoAmmount);
            Destroy(gameObject);
        }
    }
}

