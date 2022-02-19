using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private SkinnedMeshRenderer meshRenderer;
    private Color originColor;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        originColor = meshRenderer.material.color;
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("OnHit");
        StartCoroutine("OnHitColor");
    }

    private IEnumerator OnHitColor()
    {
        meshRenderer.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        meshRenderer.material.color = originColor;
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
