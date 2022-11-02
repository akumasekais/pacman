using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour {

    public GameObject target; // this is the player
    UnityEngine.AI.NavMeshAgent agent; //this is ghost component reference

    // Start is called before the first frame update
    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        agent.destination = target.transform.position;
    }
    //function to detect when the ghost gets player
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Player")
            SceneManager.LoadScene("Menu");
    }
}
