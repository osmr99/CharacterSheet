using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName = "YourName";
    [SerializeField] int proficiency = 0;
    [SerializeField] bool finesseWeapon = false;
    [SerializeField] [Range(-5, 5)] int STR = 0;
    [SerializeField] [Range(-5, 5)] int DEX = 0;

    // Start is called before the first frame update
    
    void Start()
    {
        int hitModifier = 0;
        int damage = 0;
        int hitModifierCase = 0;
        if (finesseWeapon == false)
        {
            // No finesse weapon, so STR it's used to get the hit modifier.
            hitModifier = STR + proficiency;
            if(hitModifier > 0)
                Debug.Log(characterName + "'s hit modifier is +" + hitModifier);
            if(hitModifier == 0)
                Debug.Log(characterName + "'s hit modifier is " + hitModifier);
            if(hitModifier < 0)
                Debug.Log(characterName + "'s hit modifier is " + hitModifier);
            // All the possible outcomes when the enemy AC is revealed.
            int enemyAC = UnityEngine.Random.Range(10, 21);
            if (enemyAC == 10)
            {
                Debug.Log("OH YEAHHHH!!! Enemy AC is " + enemyAC + "!!");
                Debug.Log(characterName + " rolled the D20 with complete confidence.");
            }
            if (enemyAC >= 11 && enemyAC <= 14)
            {
                Debug.Log("Enemy AC is " + enemyAC + ". Alright then!");
                Debug.Log(characterName + " rolled the D20 calmly.");
            }
            if (enemyAC >= 15 && enemyAC <= 18)
            {
                Debug.Log("Enemy AC is " + enemyAC + ". Okay... There's hope.");
                Debug.Log("Nervous but hopeful, " + characterName + " rolled the D20.");
            }
            if (enemyAC == 19)
            {
                Debug.Log("Enemy AC is " + enemyAC + ", " + characterName + ", gotta clutch!");
                Debug.Log(characterName + " starts to sweat, scared of missing the hit.");
                Debug.Log(characterName + " takes a deep breath and rolls the D20.");
            }
            if (enemyAC == 20)
            {
                Debug.Log("SECRET ENEMY WITH AN ARMOR CLASS OF " + enemyAC + " HAS APPEARED!! Only a miracle can save you...");
                Debug.Log(characterName + "'s heart starts beating rapidly all of the sudden.");
                Debug.Log(characterName + " shook and blew air on the D20.");
                Debug.Log(characterName + " rolls the D20, will it hit?");
            }
            // Player rolls the D20, with different outcomes.
            int D20 = UnityEngine.Random.Range(1, 21);
            if (D20 == 1)
                Debug.Log(characterName + " rolled a " + D20 + ".....");
            if (D20 >= 2 && D20 <= 5)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 6 && D20 <= 10)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 11 && D20 <= 15)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 16 && D20 <= 18)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 == 19)
                Debug.Log(characterName + " rolled a " + D20 + ". Almost PERFECT.");
            if (D20 == 20)
                Debug.Log("WHAT AN AMAZING LUCK!!! " + characterName + " rolled a PERFECT " + D20 + "! Congrats!");
            damage = hitModifier + D20;
            if (damage >= enemyAC)
                Debug.Log(characterName + " hits the enemy! Great!");
            if (damage < enemyAC)
                Debug.Log(characterName + " missed... Nooooooooo");   
        }
        if (finesseWeapon == true)
        {
            // Finesse Weapon is true.
            // Finding if STR or DEX is greater.
            if (STR > DEX)
            {
                hitModifier = STR + proficiency;
                hitModifierCase = 1;
            }
            if (DEX > STR)
            {
                hitModifier = DEX + proficiency;
                hitModifierCase = 2;
            }
            // The values are equal.
            if (DEX == STR)
            {
                hitModifierCase = 3;
                // Choosing which one to use at random, just for fun.
                int DexOrStr = UnityEngine.Random.Range(1, 3);
                if (DexOrStr == 1)
                {
                    hitModifier = STR + proficiency;
                }
                if (DexOrStr == 2)
                {
                    hitModifier = DEX + proficiency;
                }
            }
            if(hitModifier > 0)
            {
                if (hitModifierCase == 1)
                {
                    Debug.Log(characterName + "'s hit modifier is +" + hitModifier + " since STR is higher than DEX.");
                }
                if (hitModifierCase == 2)
                {
                    Debug.Log(characterName + "'s hit modifier is +" + hitModifier + " since DEX is higher than STR.");
                }
                if (hitModifierCase == 3)
                {
                    Debug.Log(characterName + "'s hit modifier is +" + hitModifier + " since STR and DEX are the same value.");
                }
            }
            if(hitModifier == 0)
            {
                if (hitModifierCase == 1)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since STR is higher than DEX.");
                }
                if (hitModifierCase == 2)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since DEX is higher than STR.");
                }
                if (hitModifierCase == 3)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since STR and DEX are the same value.");
                }
            }
            if(hitModifier < 0)
            {
                if (hitModifierCase == 1)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since STR is higher than DEX.");
                }
                if (hitModifierCase == 2)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since DEX is higher than STR.");
                }
                if (hitModifierCase == 3)
                {
                    Debug.Log(characterName + "'s hit modifier is " + hitModifier + " since STR and DEX are the same value.");
                }
            }
            // All the possible outcomes when the enemy AC is revealed.
            int enemyAC = UnityEngine.Random.Range(10, 21);
            if (enemyAC == 10)
            {
                Debug.Log("OH YEAHHHH!!! Enemy AC is " + enemyAC + "!!");
                Debug.Log(characterName + " rolled the D20 with complete confidence.");
            }
            if (enemyAC >= 11 && enemyAC <= 14)
            {
                Debug.Log("Enemy AC is " + enemyAC + ". Alright then!");
                Debug.Log(characterName + " rolled the D20 calmly.");
            }
            if (enemyAC >= 15 && enemyAC <= 18)
            {
                Debug.Log("Enemy AC is " + enemyAC + ". Okay... There's hope.");
                Debug.Log("Nervous but hopeful, " + characterName + " rolled the D20.");
            }
            if (enemyAC == 19)
            {
                Debug.Log("Enemy AC is " + enemyAC + ", " + characterName + " gotta clutch!");
                Debug.Log(characterName + " starts to sweat, scared of missing the hit.");
                Debug.Log(characterName + " takes a deep breath and rolls the D20.");
            }
            if (enemyAC == 20)
            {
                Debug.Log("SECRET ENEMY WITH AN ARMOR CLASS OF " + enemyAC + " HAS APPEARED!! Only a miracle can save you...");
                Debug.Log(characterName + "'s heart starts beating rapidly all of the sudden.");
                Debug.Log(characterName + " shook and blew air on the D20.");
                Debug.Log(characterName + " rolls the D20, will it hit?");
            }
            // Player rolls the D20, with different outcomes.
            int D20 = UnityEngine.Random.Range(1, 21);
            if (D20 == 1)
                Debug.Log(characterName + " rolled a " + D20 + ".....");
            if (D20 >= 2 && D20 <= 5)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 6 && D20 <= 10)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 11 && D20 <= 15)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 >= 16 && D20 <= 18)
                Debug.Log(characterName + " rolled a " + D20 + ".");
            if (D20 == 19)
                Debug.Log(characterName + " rolled a " + D20 + ". Almost PERFECT.");
            if (D20 == 20)
                Debug.Log("WHAT AN AMAZING LUCK!!! " + characterName + " rolled a PERFECT " + D20 + "! Congrats!");
            damage = hitModifier + D20;
            if (damage >= enemyAC)
                Debug.Log(characterName + " hits the enemy! Great!");
            if (damage < enemyAC)
                Debug.Log(characterName + " missed... Nooooooooo");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}