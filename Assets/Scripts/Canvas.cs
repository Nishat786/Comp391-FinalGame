using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour {

    public static Canvas instance = null;
    public GameObject youWin;
	public void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
	}
	public void Win ()
    {
        youWin.SetActive(true);
	}
}
