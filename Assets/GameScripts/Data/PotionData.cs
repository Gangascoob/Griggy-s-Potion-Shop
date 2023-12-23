using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "GameScripts/Data/PotionData", order = 1)]

public class PotionData : ScriptableObject
{
    public string itemName;

    public int id;

    public float saleRate;

    public int salePrice;
}