using UnityEngine;

public class AnimatorController : MonoSingleton<AnimatorController>
{
    public Animator animator;
    public int directions;
    void Update()
    {


        // Per impostare un int
        
        if(directions==-1)
        {
            animator.SetInteger("Direction", -1);
        }

        if(directions==1)
        {
            animator.SetInteger("Direction", 1);
        }

        //if (directions == -2)
        //{
        //    animator.SetInteger("Direction", -2);
        //}

        //if (directions == 2)
        //{
        //    animator.SetInteger("Direction", 2);
        //}

    }
}
