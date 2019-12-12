using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public TargetTag targetTag;
    public TargetTag targetTag2;

    public Transform Target;


    private NavMeshAgent myNavMeshAgent;

    public string TagTarget;

    

    // Start is called before the first frame update
    void Start()
    {

        

        myNavMeshAgent = GetComponent<NavMeshAgent>();
        //GetComponent<NavMeshAgent>().speed = 10;

        TagTarget = targetTag.ToString();

    }

    // Update is called once per frame
    void Update()
    {


        if (GameObject.FindGameObjectWithTag(TagTarget) != null)
        {

            Target = GameObject.FindGameObjectWithTag(TagTarget).transform;

        }
        







        if (Target != null)
        {
            if (myNavMeshAgent.enabled == true)
            {
                myNavMeshAgent.SetDestination(Target.position);

            }


        }





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString() || other.gameObject.tag == targetTag2.ToString())
        {
            follow();
            
        }
        void follow()
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }

  

}

