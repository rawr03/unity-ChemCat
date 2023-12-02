using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAnim : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Anim, good, great, perfect;
    

    void Start()
    {
        //Anim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(good.activeSelf == true || great.activeSelf == true || perfect.activeSelf == true)
        {
            Anim.SetActive(true);
        }
    }
}
