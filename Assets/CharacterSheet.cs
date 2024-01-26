using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName = "YourName";
    [SerializeField] int proficiency = 0;
    [SerializeField] bool finesseWeapon = true;
    [SerializeField] [Range(-5, 5)] int STR = 0;
    [SerializeField] [Range(-5, 5)] int DEX = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}