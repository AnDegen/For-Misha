using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootNewGunOrAmmo : MonoBehaviour
{
    public int index;
    public int numberOfAmmoToAdd;

    public void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerArmory>())
            {
                other.attachedRigidbody.GetComponent<PlayerArmory>().AddNewGunOrAmmo(index, numberOfAmmoToAdd);
                Destroy(gameObject);
            }
        
    }
}
