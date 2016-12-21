using UnityEngine;
using System.Collections;

public class weaponSwitching : MonoBehaviour {

    public GameObject weapon1;
    public GameObject weapon2;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SwapWeapon();
        }
	
	}

    void SwapWeapon()
    {
       if(weapon1.activeSelf)
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
        }
        else
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
        }
    }
}
