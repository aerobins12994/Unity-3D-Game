using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_Up : MonoBehaviour {

    //public RayCast_Shoot RayCast_Shoot2;
    public GameObject fadedOutItem1;
    public GameObject pickedUpItem1;
    public GameObject getTotalAmmo;
    public GameObject resetHealth;
    public int distance;
    public int item_count = 0;
    public int item_count2 = 0;
    public int item_count3 = 0;
    
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Collect();
	
	}

    void Collect()
    {
      if(Input.GetMouseButtonUp(1))
        {
            //Debug.Log(item_count);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, distance))
            {
                if(hit.collider.gameObject.name == "item")
                {
                    Debug.Log("item hit");
                    Destroy(hit.collider.gameObject);
                    item_count++;
                    Debug.Log(item_count);
                    fadedOutItem1.SetActive(false);
                    pickedUpItem1.SetActive(true);
                }
                if (hit.collider.gameObject.name == "item1")
                {
                    Debug.Log("item1 hit");
                    Destroy(hit.collider.gameObject);
                    item_count2++;
                    
                    fadedOutItem1.SetActive(false);
                    pickedUpItem1.SetActive(true);
                }

                if (hit.collider.gameObject.name == "item2")
                {
                    Debug.Log("item1 hit");
                    Destroy(hit.collider.gameObject);
                    item_count3++;

                    fadedOutItem1.SetActive(false);
                    pickedUpItem1.SetActive(true);
                }
                if (hit.collider.gameObject.name == "Ammo_pack")
                {
                    Debug.Log("Ammo hit");
                    getTotalAmmo.GetComponent<RayCast_Shoot>().totalAmmo = 50;
                    Destroy(hit.collider.gameObject);
                    Debug.Log(getTotalAmmo);
                }
                if (hit.collider.gameObject.name == "health")
                {
                    Debug.Log("health hit");
                    resetHealth.GetComponent<PlayerHealth>().currentHealth = 100;
     
                    Destroy(hit.collider.gameObject);
                    fadedOutItem1.SetActive(false);
                    pickedUpItem1.SetActive(true);
                }
            }

            if(item_count == 1)
            {
                SceneManager.LoadSceneAsync("demoLevel2");
            }
            if(item_count2 == 2)
            {
                SceneManager.LoadSceneAsync("demoLevel3");
            }
            if(item_count3 == 4)
            {
                SceneManager.LoadSceneAsync("gameWon");
            }
        }
    }
}
