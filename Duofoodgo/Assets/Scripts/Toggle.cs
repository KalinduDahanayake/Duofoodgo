using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject hat;

    public void wear()
    {
        if (hat.activeSelf == true)
        {
            hat.SetActive(false);
        }
        else
        {
            foreach (GameObject current in GameObject.FindGameObjectsWithTag("hat"))
            {
                current.SetActive(false);
            }
            hat.SetActive(true);
        }
    }

}
