using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Combat : MonoBehaviour
{
    bool isAttacking = false;
    public CombatInfo spec;
    public ContactFilter2D filter;
    [SerializeField]
    float atcOffset = 1f;

    private void Awake()
    {
        GetComponent<ChController>().att += Attack;
        
    }

    public void Attack()
    {
        Vector3 pos = new Vector3(transform.position.x + atcOffset * transform.localScale.x, transform.position.y+.5f,0f);
        RaycastHit2D[] _hits = Physics2D.RaycastAll(pos, Vector2.right * transform.localScale.x,spec.weaponReach,LayerMask.GetMask("Enemy"));
        for (int i = 0; i < _hits.Length; i++)
        {
            _hits[i].transform.GetComponent<TargetHitRegister>().ReceiveOof();
        }
        Debug.Log(_hits.Length);
    }
    private void OnDrawGizmosSelected()
    {
        Vector3 pos = new Vector3((transform.position.x )+ atcOffset * transform.localScale.x, transform.position.y,0f);
        Gizmos.DrawWireCube(pos,Vector3.one * spec.weaponReach);
        Gizmos.DrawLine(pos, new Vector3(pos.x + spec.weaponReach * transform.localScale.x,pos.y,0f));
    }
}
