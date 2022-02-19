using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayherAttackCollision : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine("AutoDisable");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            other.GetComponent<EnemyController>().TakeDamage(10);
    }

    private IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
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
