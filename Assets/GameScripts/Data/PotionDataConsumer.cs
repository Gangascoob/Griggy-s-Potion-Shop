using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionDataConsumer : MonoBehaviour
{

    public PotionDataManager potionDataManager;

    public int potionDataID;

    private PotionData cachedData;

    // Start is called before the first frame update
    void Start()
    {
        if(potionDataManager != null)
        {
            //PotionData potionData = potionDataManager.GetPotionDataByID(potionDataID);

            cachedData = potionDataManager.GetPotionDataByID(potionDataID);

            if(cachedData != null)
            {
                string itemName = cachedData.itemName;
                int id = cachedData.id;
                float saleRate = cachedData.saleRate;
                int salePrice = cachedData.salePrice;
            }
            else
            {
                Debug.LogError($"CustomData with ID {potionDataID} not found!");
            }
        }
        else
        {
            Debug.LogError("PotionDataManager is unassigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
