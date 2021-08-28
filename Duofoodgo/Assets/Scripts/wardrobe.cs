using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardrobe : MonoBehaviour
{
    public GameObject background;
    public int position;

    // Start is called before the first frame update
    public void Open()
    {
        background.transform.localPosition = new Vector3(0, position, 0);
    }

}
