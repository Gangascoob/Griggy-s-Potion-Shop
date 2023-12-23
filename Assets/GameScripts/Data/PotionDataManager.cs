using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionDataManager : MonoBehaviour
{

    public PotionData[] dataArray;
    private Dictionary<int, PotionData> potionDataDictionary = new Dictionary<int, PotionData>();


    private void Awake()
    {
        foreach (PotionData data in dataArray)
        {
            potionDataDictionary[data.id] = data;
        }
    }


    public PotionData GetPotionDataByID(int id)
    {
        if (potionDataDictionary.TryGetValue(id, out PotionData cachedData))
        {
            return cachedData;
        }


        foreach (PotionData data in dataArray)
        {
            if(data.id == id)
            {
                potionDataDictionary[id] = data;
                return data;
            }
        }

        return null;
    }

    public bool GetSaleData(int id, out int salePrice, out float saleRate)
    {
        salePrice = 0;
        saleRate = 0f;

        PotionData potionData = GetPotionDataByID(id);

        if(potionData != null)
        {
            salePrice = potionData.salePrice;
            saleRate = potionData.saleRate;
            return true;
        }

        return false;
    }
}
