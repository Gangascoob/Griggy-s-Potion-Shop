using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Select : MonoBehaviour
{

    private int Slot;
    private bool slotSelected = false;

    [SerializeField] private GameObject slotOne;
    [SerializeField] private GameObject slotTwo;

    private GameObject selectedSlot;

    private float newSaleRate;
    private int newSalePrice;

    private Image slotImage;
    private Sprite slotSprite;
    [SerializeField] private Sprite originalSprite;
    [SerializeField] private Sprite[] spriteArr;

    private Color _potionColor;
    private Color _emptyColor;

    public PotionDataManager potionDataManager;
    public SaleScript saleScript;

    private bool slotOneLock = false;
    private bool slotTwoLock = false;
   
    void Start()
    {
        _potionColor = new Color(209, 187, 125, 109);
        _emptyColor = new Color(209, 187, 125, 255);
    }

   
    void Update()
    {
        
    }

    public void SelectSlot(int slot)
    {
        Slot = slot;
        slotSelected = true;
        if(slot == 1 && slotOneLock == false)
        {
            selectedSlot = slotOne;
        }
        if(slot == 2 && slotTwoLock == false)
        {
            selectedSlot = slotTwo;
        }
        Debug.Log("Slot Selected");
    }

    public void SelectPotion(int slotID)
    {

        if(slotSelected == true)
        {
            GetValues(slotID);
            slotSprite = spriteArr[slotID];
            slotImage = selectedSlot.GetComponent<Image>();
            slotImage.sprite = slotSprite;
            slotSelected = false;
            slotImage.color = _potionColor;
            saleScript.SetSale(newSaleRate, newSalePrice, Slot);
        }
        
        
        
    }

    public void GetValues(int id)
    {
        bool success = potionDataManager.GetSaleData(id, out int salePrice, out float saleRate);

        if (success)
        {
            Debug.Log($"Sale Price: {salePrice}, Sale Rate: {saleRate}");
            newSaleRate = saleRate;
            newSalePrice = salePrice;
        }

        else
        {
            Debug.LogError($"PotionData with ID {id} not found!");
        }
    }

    public void EmptySlot(int slot)
    {
        if(slot == 1)
        {
            selectedSlot = slotOne;
           
        }
        if(slot == 2)
        {
            selectedSlot = slotTwo;
        }

        slotImage = selectedSlot.GetComponent<Image>();
        slotImage.sprite = originalSprite;
        slotImage.color = _emptyColor;
    }

}
