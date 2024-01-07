using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Select : MonoBehaviour
{

    private int Slot;
    private int stock;
    private bool slotSelected = false;

    [SerializeField] private GameObject[] slotSelection;

    private GameObject selectedSlot;

    private float newSaleRate;
    private int newSalePrice;

    private Image slotImage;
    private Sprite slotSprite;
    [SerializeField] private Sprite originalSprite;
    [SerializeField] private Sprite[] spriteArr;

    private bool[] slotLocks;
    
    private Color _potionColor;
    private Color _emptyColor;

    public PotionDataManager potionDataManager;
    public SaleScript saleScript;
    public PotionStockController stockController;

    private bool slotOneLock = false;
    private bool slotTwoLock = false;
   
    void Start()
    {
        _potionColor = new Color(209, 187, 125, 109);
        _emptyColor = new Color(209, 187, 125, 255);
        slotLocks = new bool[4];
        slotLocks[0] = false;
        slotLocks[1] = false;
        slotLocks[2] = false;
        slotLocks[3] = false;
    }

   
    void Update()
    {
        
    }

    public void SelectSlot(int slot)
    {
        if (slotLocks[slot] == false)
        {
            Slot = slot;
            slotSelected = true;
            selectedSlot = slotSelection[slot];
            Debug.Log("Slot Selected");
            slotLocks[slot] = true;
        }

       
    }

    public void SelectPotion(int slotID)
    {
        stock = stockController.returnStock(slotID);
        if(slotSelected == true && stock > 0)
        {
            GetValues(slotID);
            slotSprite = spriteArr[slotID];
            slotImage = selectedSlot.GetComponent<Image>();
            slotImage.sprite = slotSprite;
            slotSelected = false;
            slotImage.color = _potionColor;
            saleScript.SetSale(newSaleRate, newSalePrice, Slot, slotID);
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
        selectedSlot = slotSelection[slot];

        slotImage = selectedSlot.GetComponent<Image>();
        slotImage.sprite = originalSprite;
        slotImage.color = _emptyColor;
        slotLocks[slot] = false;
    }

}
