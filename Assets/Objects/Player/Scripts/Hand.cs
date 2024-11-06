using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private Transform weaponPlacer;
    [SerializeField] private float pickupDistance;
    [SerializeField] private string weaponTag;

    public GameObject currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Instance.GetControls().Hand.PickUpItem.started += _ => PickUpWeapon();
        InputManager.Instance.GetControls().Hand.Interact.started += _ => OpenChest();
    }


    void PickUpWeapon()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickupDistance);

        foreach (Collider col in hitColliders)
        {
            if (col.CompareTag(weaponTag) && col.gameObject != currentWeapon) 
            {
                PlaceWeapon(col.gameObject);
                break;
            }


        }
    }

    void PlaceWeapon(GameObject weapon)
    {
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        weapon.transform.parent = weaponPlacer;
        weapon.transform.SetPositionAndRotation(weaponPlacer.position, weaponPlacer.rotation);
        currentWeapon = weapon;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;

        Debug.Log(currentWeapon.name);
    }

    void OpenChest()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickupDistance);

        foreach (Collider col in hitColliders)
        {
            if (col.GetComponent<Chest>() != null) col.GetComponent<Chest>().OpenChest();

        }
    }
}
