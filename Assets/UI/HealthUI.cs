using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {
    public List<GameObject> textList;
    ObjectHealth cube;
    public Image hp;
    public GameObject target;
    public float offset;
    private bool active;
  
        void Start()
    {
        active = true;
        cube = target.GetComponent<ObjectHealth>();
    }
	
	void Update () {
//Updates HealthBars position if object it is attached moves and offset set it so it's on top of object 
        if (active)
        {
            transform.position = Camera.main.WorldToScreenPoint((Vector3.up * offset) + target.transform.position);
        }
	}
//Updates health image to show correct amount of color
    public void MinusHealth(float damage)
    {
       hp.fillAmount = (float)cube.health / (float)cube.startHealth;
       GetEmptyText(damage);
    }
//Sets HealthBar disabled 
    public void DisableHealthBar()
    {
        active = false;
        gameObject.SetActive(false);
    }
//Finds empty text object form list and activates it
//Then it gives an amount how much damage was
    public void GetEmptyText(float dmg)
    {
        for (int i = 0; i < textList.Count; i++)
        {
            if (!textList[i].activeInHierarchy)
            {
                textList[i].SetActive(true);
                textList[i].GetComponent<TextEffect>().PopupEffect(dmg);
                break;
            }
        }
    }
    
 
}
