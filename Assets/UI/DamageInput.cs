using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInput : MonoBehaviour {
    ObjectHealth cube;
    
	/*
	* THIS SCRIPT SENDS RANDOMISED DAMAGE VALUE TO OBJECT HEALTH SCRIPT WHEN CLICKED
	*/
	
    void Start () {
        cube = GetComponent<ObjectHealth>();
	}
	
	void Update () {
        float damageToMake = Random.Range(0, 20);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if (hit.transform.name == "Cube")
            {
                cube.TakeDamage(damageToMake);
            }
        }
    }
}
