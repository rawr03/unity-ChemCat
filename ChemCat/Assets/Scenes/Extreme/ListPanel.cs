using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPanel : MonoBehaviour
{
    public GameObject listPanel;
    public Animator animator;
    public Animator animator1;

    public void listGoUp()
    {
        animator.Play("listUp");
        DelayAnim();
        animator.SetBool("pressed", true);
        //listPanel.SetActive(false);
    }

    IEnumerator DelayAnim()
    {
        yield return new WaitForSeconds(3);
        listPanel.SetActive(false);
    }

    public void listGoDown()
    {
        listPanel.SetActive(true);
        animator1.Play("listDown");
        animator1.SetBool("pressed", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
