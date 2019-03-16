using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public static int ammo;
    public GameObject ammoPickup;

    Text text;
    float spawnRate = 10.0f;
    float nextSpawn = 0.0f;

    void Awake ()
    {
        text = GetComponent<Text>();
        ammo = 150;
    }


    void Update()
    {
        text.text = "Ammunition: " + ammo;
        if (ammo <= 0 && Time.time >= nextSpawn)
        {
            Instantiate(ammoPickup);
            nextSpawn = Time.time + spawnRate;
        }
        
        
    }



}