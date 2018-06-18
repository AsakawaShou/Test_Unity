using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Player : MonoBehaviour {

    public GameObject M_Camera;

    private void Start()
    {
        M_Camera = Camera.main.gameObject;
    }




}
