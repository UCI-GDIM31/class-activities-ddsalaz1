using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour{

[SerializeField] private GameObject target;

private NavMeshAgent _navMeshAgent;

private Vector3 _position;

private void Start(){
    _navMeshAgent = GetComponent<NavMeshAgent>();
    _position = target.transform.position;
}

private void Update(){

    _navMeshAgent.SetDestination(_position);

}

}
