using UnityEngine;
using System.Collections;

/* Edit Notes:
 * 
 * Edited By: NPi
 * Edit Time: 12/20/16
 * Description:
 * Switched using .active to .activeSelf, .active is deprecated. ALso fixed incorrect if statement assignemnt to check for equals compaison.
 * Updated weapon1 and weapon2 to .SetActive as this is inherited by all the children elements and .SetActiveRecursively is not needed
 * 
 */

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