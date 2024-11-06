using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Transform trans;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip whoosh;
    [SerializeField] private AudioClip hit;
    [SerializeField] private Animator animator;
    [SerializeField] private float attackDelay = 1f; // Delay between button press and attack
    [SerializeField] private float attackCooldown = 1f;
    [SerializeField] private float minAttackDistance;
    public float attackSpeedMultiplier = 1.25f; // Speed multiplier during attack

    private bool isAttacking = false; // Flag to track if an attack is in progress

    [SerializeField] private BoxCollider attackCollider;

    public LayerMask target; // Layer mask for enemies

    private bool isPlayer;

    private EnemyMovementAI movementAI;

    private void Start()
    {
        if(GetComponent<PlayerMovement>() != null)
        {
            isPlayer = true;
            InputManager.Instance.GetControls().Attack.Attack.started += _ => StartAttack();
        }
        else
        {
            isPlayer = false;
            movementAI = GetComponent<EnemyMovementAI>();
        }
    }

    public void Update()
    {
        if (!isPlayer)
        {
            if(movementAI.DistanceToTarget < minAttackDistance)
            {
                if (!isAttacking)
                {
                    EnemyAttack();
                }
            }
        }
    }

    private void StartAttack()
    {
        if (!isAttacking)
        {
            StartCoroutine(AttackDelay());
        }
    }

    private void EnemyAttack()
    {
        if (!isAttacking)
        {
            StartCoroutine(EnemyAttackDelay());
        }
    }

    private IEnumerator AttackDelay()
    {
        float cooldown = GetComponent<Hand>().currentWeapon.GetComponent<Weapon>().coolDownTime;
        isAttacking = true; // Set the flag to indicate an attack is in progress
        animator.SetBool("IsAttacking", true);
        //SetAttackSpeedMultiplier(3f);
        PlayWhoosh();
        yield return new WaitForSeconds(attackDelay); // Wait for the delay
        PlayHit();

        // After the delay, perform the attack
        CmdAttack();

        animator.SetBool("IsAttacking", false);
        //SetAttackSpeedMultiplier(0.1f);
        yield return new WaitForSeconds(attackCooldown + cooldown);
        //ResetAttackSpeed();
        isAttacking = false; // Reset the flag after the attack
    }

    private IEnumerator EnemyAttackDelay()
    {
        isAttacking = true; // Set the flag to indicate an attack is in progress
        animator.SetBool("IsAttacking", true);
        //SetAttackSpeedMultiplier(3f);
        PlayWhoosh();
        yield return new WaitForSeconds(attackDelay); // Wait for the delay
        PlayHit();

        // After the delay, perform the attack
        CmdEnemyAttack();

        animator.SetBool("IsAttacking", false);
        //SetAttackSpeedMultiplier(0.1f);
        yield return new WaitForSeconds(attackCooldown);
        //ResetAttackSpeed();
        isAttacking = false; // Reset the flag after the attack
    }

    private void PlayWhoosh()
    {
        source.clip = whoosh;
        source.Play();
    }

    private void PlayHit()
    {
        source.clip = hit;
        source.Play();
    }

    private void CmdEnemyAttack()
    {
        Collider[] hitColliders = Physics.OverlapBox(trans.TransformPoint(attackCollider.center), attackCollider.size * 0.5f, attackCollider.transform.rotation, target);
        if (hitColliders.Length > 0)
        {
            foreach (Collider collider in hitColliders)
            {
                if (collider.isTrigger) continue;
                collider.GetComponent<Health>()?.TakeDamage(1);
            }
        }
    }

    private void CmdAttack()
    {
        int damage = GetComponent<Hand>().currentWeapon.GetComponent<Weapon>().damage;
        bool isSplash = GetComponent<Hand>().currentWeapon.GetComponent<Weapon>().isSplash;

        Collider[] hitColliders = Physics.OverlapBox(trans.TransformPoint(attackCollider.center), attackCollider.size * 0.5f, attackCollider.transform.rotation, target);
        if (hitColliders.Length > 0)
        {
            if (isSplash)
            {
                foreach (Collider collider in hitColliders)
                {
                    if (collider.isTrigger) continue;
                    collider.GetComponent<Health>()?.TakeDamage(damage);
                }
            }
            else
            {
                Health health = null;
                float distance = float.MaxValue;
                foreach (Collider collider in hitColliders)
                {
                    if (collider.isTrigger) continue;
                    if (collider.GetComponent<Health>() != null)
                    {
                        if(Vector3.Distance(collider.transform.position, transform.position) < distance)
                        {
                            distance = Vector3.Distance(collider.transform.position, transform.position);
                            health = collider.GetComponent<Health>();
                        }
                    }
                }

                if(health != null)
                {
                    health.TakeDamage(damage);
                }
            }
        }
    }

    public void SetAttackSpeedMultiplier(float multiplier)
    {
        attackSpeedMultiplier = multiplier;
    }

    public void ResetAttackSpeed()
    {
        attackSpeedMultiplier = 1f;
    }
}