using UnityEngine;

public class AnimationControllerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("W"))
        {
            animator.SetBool("isWalking", true);
        }
        if (!Input.GetKey("W"))
        {
            animator.SetBool("isWalking", true);
        }
    }
}
