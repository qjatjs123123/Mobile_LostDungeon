using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnController : MonoBehaviour
{
    public Image AttackBtn;
    public PlayerAnimator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        playerAnimator.OnWeaponAttack();
    }
}
