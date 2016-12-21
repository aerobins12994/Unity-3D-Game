// By Ruoyu Li

using UnityEngine;
using System.Collections;



public class map : MonoBehaviour {

    //map size
    int[] size = { 10, 10 };

    //player position
	public int[] initial = { 9, 5 };
    //monster postition
    public int[] monsterPos = { 1, 0 };
    //coin position
    public int[] coinPos = { 1, 1};
	//ammo pack position
	public int[] ammoPos = { 5, 5};

    //vertical and horizontal walls (including edges), 0 stands for wall, and 1 stands for passage
    //vWall[ size[0], size[1] + 1 ]
    /* //level 1
    int[,] vWall = new int[10, 11]  {
                                        { 0,1,1,1,0,1,0,1,0,1,0}, //1
                                        { 0,1,0,0,0,1,0,0,1,1,0}, //2
                                        { 0,1,0,1,0,1,0,1,0,1,0}, //3
                                        { 0,0,1,1,1,0,1,1,1,0,0}, //4
                                        { 0,0,1,1,1,1,0,1,0,1,0}, //5
                                        { 0,0,1,1,0,1,0,1,0,1,0}, //6
                                        { 0,0,1,0,0,1,1,1,1,0,0}, //7
                                        { 0,1,1,0,0,0,1,0,0,1,0}, //8
                                        { 0,1,0,1,0,1,0,0,0,1,0}, //9
                                        { 0,1,1,1,1,0,1,0,1,0,0} //10
                                    };
    //hWall[ size[0] + 1, size[1] ]
    int[,] hWall = new int[11, 10] {
                                        { 0,0,0,0,0,0,0,0,0,0}, //1
                                        { 1,0,1,1,1,0,1,1,0,1}, //2 
                                        { 0,1,1,0,0,1,1,0,0,1}, //3
                                        { 1,0,0,1,1,0,0,1,0,0}, //4
                                        { 1,1,0,0,0,1,0,1,1,1}, //5
                                        { 1,0,0,0,0,1,1,0,1,0}, //6
                                        { 1,1,0,1,0,0,0,0,0,1}, //7
                                        { 1,0,0,1,1,0,0,1,1,1}, //8
                                        { 0,0,1,1,1,1,1,1,0,0}, //9
                                        { 1,0,1,0,0,0,1,1,1,1}, //10
                                        { 0,0,0,0,0,0,0,0,0,0}, //11
                                   };*/

	/*//level 2
	int[,] vWall = new int[10, 11]  {
		{ 0,1,0,1,1,0,1,0,1,0,0}, //1
		{ 0,0,1,0,0,0,0,0,0,1,0}, //2
		{ 0,1,1,0,1,0,1,1,1,1,0}, //3
		{ 0,1,0,0,0,1,0,1,1,1,0}, //4
		{ 0,1,0,1,0,1,0,0,0,1,0}, //5
		{ 0,0,0,1,1,0,1,0,1,1,0}, //6
		{ 0,1,0,1,1,0,0,1,0,1,0}, //7
		{ 0,1,1,0,0,1,0,0,1,1,0}, //8
		{ 0,0,1,0,0,0,1,0,0,0,0}, //9
		{ 0,1,1,1,0,1,0,1,1,0,0} //10
	};
	//hWall[ size[0] + 1, size[1] ]
	int[,] hWall = new int[11, 10] {
		{ 0,0,0,0,0,0,0,0,0,0}, //1
		{ 1,1,1,1,1,1,1,1,1,1}, //2 
		{ 1,0,0,1,0,1,0,1,0,0}, //3
		{ 1,0,1,0,1,1,0,0,0,1}, //4
		{ 0,1,1,1,1,0,1,0,1,0}, //5
		{ 1,1,0,0,1,0,1,1,0,1}, //6
		{ 0,1,1,0,0,1,0,1,0,1}, //7
		{ 1,0,0,0,0,1,1,0,0,0}, //8
		{ 0,0,1,1,1,0,1,1,1,1}, //9
		{ 1,1,0,1,1,0,1,0,1,1}, //10
		{ 0,0,0,0,0,0,0,0,0,0}, //11
	};*/

	//level 3
	int[,] vWall = new int[10, 11]  {
		{ 0,0,1,1,0,0,1,1,1,1,0}, //1
		{ 0,1,1,0,1,0,0,1,1,0,0}, //2
		{ 0,0,1,0,1,1,0,0,1,0,0}, //3
		{ 0,0,1,1,1,0,1,1,0,0,0}, //4
		{ 0,1,1,0,1,0,1,0,0,1,0}, //5
		{ 0,1,0,1,0,1,1,0,1,1,0}, //6
		{ 0,0,1,1,0,0,0,1,1,0,0}, //7
		{ 0,0,0,0,1,0,1,0,1,0,0}, //8
		{ 0,0,0,1,0,1,0,1,1,0,0}, //9
		{ 0,0,1,1,1,0,0,1,1,1,0} //10
	};
	//hWall[ size[0] + 1, size[1] ]
	int[,] hWall = new int[11, 10] {
		{ 0,0,0,0,0,0,0,0,0,0}, //1
		{ 1,1,0,1,1,1,0,0,1,1}, //2 
		{ 1,0,1,0,0,1,1,0,0,1}, //3
		{ 1,1,0,0,1,0,1,1,1,1}, //4
		{ 1,0,0,0,0,1,0,0,1,0}, //5
		{ 1,0,1,1,0,0,1,1,0,1}, //6
		{ 1,0,0,0,1,0,0,0,0,1}, //7
		{ 1,1,0,1,1,1,1,0,1,1}, //8
		{ 1,1,1,1,0,0,1,0,0,1}, //9
		{ 1,1,0,0,1,1,0,1,0,1}, //10
		{ 0,0,0,0,0,0,0,0,0,0}, //11
	};


    //public Transform block;
    public Transform wall;
    public Transform coin;
    public Transform monster;
	public Transform ammo;
    UnityEngine.AI.NavMeshAgent nav;
    // Use this for initialization
    void Start()
    {

        int i, j;
        int m, n;
        mazeBlock.blockUnit[,] proto = new mazeBlock.blockUnit[size[0], size[1]];
        mazeBlock.blockUnit current = proto[initial[0], initial[1]];
        //


        //initializing the map, which by default connects all the neighboring blocks and walls are on the fringe
        for (i = 0; i < size[0]; i++)
        {
            for (j = 0; j < size[1]; j++)
            {
                proto[i, j].ifForward = hWall[i, j] != 0;
                proto[i, j].ifBackward = hWall[i + 1, j] != 0;
                proto[i, j].ifLeft = vWall[i, j] != 0;
                proto[i, j].ifRight = vWall[i, j + 1] != 0;

                proto[i, j].ifAmmo = false;
                proto[i, j].ifMonster = false;
                proto[i, j].ifCoin = false;
            }
        }

        //monster, coin and ammo_pack position
		for (i = 0; i < monsterPos.Length / 2; i++)
        {
            proto[monsterPos[2 * i], monsterPos[2 * i + 1]].ifMonster = true;
        }
		for (i = 0; i < coinPos.Length / 2; i++)
        {
            proto[coinPos[2 * i], coinPos[2 * i + 1]].ifCoin = true;
        }
		for (i = 0; i < ammoPos.Length / 2; i++)
		{
			proto[ammoPos[2 * i], ammoPos[2 * i + 1]].ifAmmo = true;
		}

        for (i = 0; i < size[0]; i++)
        {
            for (j = 0; j < size[1]; j++)
            {
                if (i > initial[0])
                    m = 1;
                else if (i == initial[0])
                    m = 0;
                else
                    m = -1;

                if (j > initial[1])
                    n = 1;
                else if (j == initial[1])
                    n = 0;
                else
                    n = -1;

                Vector3 pos = new Vector3(GameObject.Find("FPSController").transform.position.x + n * (10 * Mathf.Abs(j - initial[1])), 0,
                    GameObject.Find("FPSController").transform.position.z - m * (10 * Mathf.Abs(i - initial[0])));

                //Instantiate(block, pos, Quaternion.identity);
                if (!proto[i, j].ifForward) Instantiate(wall, pos + new Vector3(0, 0, 5), Quaternion.identity);
                if (!proto[i, j].ifBackward) Instantiate(wall, pos + new Vector3(0, 0, -5), Quaternion.identity);
                if (!proto[i, j].ifLeft) Instantiate(wall, pos + new Vector3(-5, 0, 0), Quaternion.Euler(0, 90, 0));
                if (!proto[i, j].ifRight) Instantiate(wall, pos + new Vector3(5, 0, 0), Quaternion.Euler(0, -90, 0));
                if (proto[i, j].ifMonster) Instantiate(monster, pos + new Vector3(0, 1, 0), Quaternion.identity);
                if (proto[i, j].ifCoin) Instantiate(coin, pos + new Vector3(0, 2, 0), Quaternion.identity);
				if (proto[i, j].ifAmmo) Instantiate(ammo, pos + new Vector3(0, 2, 0), Quaternion.identity);
            }
        }
    }
    
	// Update is called once per frame
	void Update () {
	
	}
}
