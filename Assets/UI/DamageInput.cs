using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInput : MonoBehaviour {
    ObjectHealth cube;
    
    void Start () {
        cube = GetComponent<ObjectHealth>();
	}
	
//When a object is clicked this randomises damage object takes and calls other script to take damage
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
