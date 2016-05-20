using UnityEngine;
using System.Collections;

public class iaMove : MonoBehaviour {

    private NavMeshAgent agent;
    private GameObject enemy;

    public int life;
    public int level;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
        enemy = GameObject.Find("Tank");
        life = 2;
    }
    void Update() 
    {                
        if(enemy != null)
        {
            agent.SetDestination(enemy.transform.position);
        }      
    }

    public void TakeDamage(int damage)
    {
        life = life - 1;

        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}