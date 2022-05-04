using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    [SerializeField] protected PlayerData playerStat;
    private NavMeshAgent playerAgent;
    [SerializeField] private GameObject cursorPoint;

    private void Awake()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CursorUpdate();
        playerAgent.destination = cursorPoint.transform.position;
    }

    private void CursorUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cursorPoint.transform.position = GetPositionTo(Input.mousePosition);
        }
    }

    private Vector3 GetPositionTo(Vector3 newPosition)
    {
        RaycastHit hit;
        Ray rayPosition = Camera.main.ScreenPointToRay(newPosition);
        if (Physics.Raycast(rayPosition, out hit))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
}
