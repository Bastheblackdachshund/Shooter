using UnityEngine;

public class enemieAttack : MonoBehaviour
{
    public float attackRange = 10f; 
    public float attackCooldown = 3f; 
    public int damageAmount = 1; 
    private float currentCooldown = 0f; 
    private Transform player;
    private enemymoves enemieScript;
    private bool foundPlayer;
    public Renderer ren;
    public Material defaultMaterial;
    public Material allertMaterial;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemieScript = GetComponent<enemymoves>();
        ren = GetComponent<Renderer>();
    }

    void Update()
    {
        if (currentCooldown <= 0f)
        {
            if (Vector3.Distance(transform.position, player.position) <= attackRange)
            {
                AttackPlayer();
                currentCooldown = attackCooldown;
                ren.sharedMaterial = allertMaterial;
                enemieScript.badGuy.SetDestination(player.position);
                foundPlayer = true;
            }
            else if (foundPlayer)
            {
                ren.sharedMaterial = defaultMaterial;
                enemieScript.newLocation();
                foundPlayer = false;
            }
        }
        else
        {
            currentCooldown -= Time.deltaTime;
        }
    }

    void AttackPlayer()
    {
        HP playerHealth = player.GetComponent<HP>();
        if (playerHealth != null)
        {
            playerHealth.damage(damageAmount);
        }
    }
}