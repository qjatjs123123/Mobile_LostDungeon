using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    private GameObject attackCollision;
    Animator animator;
    [SerializeField]
    private Transform characterBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        animator = characterBody.GetComponent<Animator>();
    }
    public void OnAttackCollision()
    {
        attackCollision.SetActive(true);
    }

    public void OnWeaponAttack()
    {
        animator.SetTrigger("OnWeaponAttack");
    }
}
