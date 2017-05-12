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
	
	/*
	* THIS SCRIPT:
	* - MOVES THE UI-OBJECT TO THE RIGHT POSITION RELATIVE TO GAME OBJECT
	* - GETS DAMAGE VALUE, DIVIDES MAX HEALTH BY NEW HEALTH AND USES THIS VALUE AS HEALTH UI FILL VALUE
	* - PICKS AN EMPTY UI-TEXT OBJECT, GIVES IT THE DAMAGE VALUE AND ACTIVITES IT
	*/
	
	void Update () {

        if (active)
        {
            transform.position = Camera.main.WorldToScreenPoint((Vector3.up * offset) + target.transform.position);
        }
	}

    public void MinusHealth(float damage)
    {
       hp.fillAmount = (float)cube.health / (float)cube.startHealth;
       GetEmptyText(damage);
    }

    public void DisableHealthBar()
    {
        active = false;
        gameObject.SetActive(false);
    }

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
