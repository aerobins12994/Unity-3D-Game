// By Ruoyu Li

using UnityEngine;
using System.Collections;

public class mazeBlock : MonoBehaviour {

    public struct blockUnit
    {
        //4 directions, if true then connection exists in the direction, and if false then wall stands there
        public bool ifLeft;
        public bool ifRight;
        public bool ifForward;
        public bool ifBackward;

        public bool ifMonster;
        public bool ifCoin;
        public bool ifAmmo;

    };

    
    

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    }
}
