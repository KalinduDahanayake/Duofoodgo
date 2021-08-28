using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardrobe : MonoBehaviour
{
    public GameObject background;

    // Start is called before the first frame update
    public void Open()
    {
        background.transform.localPosition = new Vector3(0, 470, 0);
    }

}
