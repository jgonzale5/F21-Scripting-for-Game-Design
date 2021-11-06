using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimator : MonoBehaviour
{
    public Animator animatorComponent;

    private void Start()
    {
        animatorComponent = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0)
        {
            animatorComponent.SetInteger("MovementType", 1);
        }
        else if (y != 0)
        {
            animatorComponent.SetInteger("MovementType", 2);
        }
        else
        {
            animatorComponent.SetInteger("MovementType", 0);
        }
    }
}
