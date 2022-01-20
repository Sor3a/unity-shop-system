using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class shope : MonoBehaviour
{
    [SerializeField] public List<item> items;
    money m;
    int j=0;
    private void Awake()
    {
        m = FindObjectOfType<money>();
        foreach (Transform item in transform)
        {
            item.gameObject.SetActive(false);
            item.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }
    private void Start()
    {

        for (int i = 0; i < items.Count; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
            transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = items[i].icon;transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = items[i].icon;
            transform.GetChild(i).gameObject.AddComponent<attachItem>();
            transform.GetChild(i).GetComponent<attachItem>().setItem(items[i]);
            transform.GetChild(i).GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            transform.GetChild(i).GetChild(1).GetComponent<TextMeshProUGUI>().text = items[i].name;
            transform.GetChild(i).GetChild(2).GetComponent<TextMeshProUGUI>().text = items[i].price.ToString() + "$";
        }
    }
    public void buyItem(item Item)
    {
        if (m.getMoney(Item.price))
            Debug.Log(Item.name);

    }
}
