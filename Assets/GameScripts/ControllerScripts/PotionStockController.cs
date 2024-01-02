using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionStockController : MonoBehaviour
{
    private int stockOne = 5;
    private int stockTwo = 0;
    private int stockThree = 0;
    private int stockFour = 0;
    private int stockFive = 0;
    private int stockSix = 0;
    private int stockSeven = 0;
    private int stockEight = 0;
    private int stockNine = 0;
    private int stockTen = 0;
    private int stockEleven = 0;
    private int stockTwelve = 0;

    private int[] stockArr;

    // Start is called before the first frame update
    void Start()
    {
        stockArr = new int[] { stockOne, stockTwo, stockThree, stockFour, stockFive, stockSix, stockSeven, stockEight, stockNine, stockTen, stockEleven, stockTwelve };

        /*
       for (int i = 0; i < 12; i++)
        {
            Debug.Log(stockArr[i]);
        }
        */
    }
    public int returnStock(int slotID)
    {
        return stockArr[slotID];
    }

    public void IncreaseStock(int value, int slotID)
    {
        stockArr[slotID] += value;
    }

    public void DecreaseStock(int value, int slotID)
    {
        if(stockArr[slotID] > 0 && value < 2)
        {
            stockArr[slotID] -= value;
        }
        
    }
}
