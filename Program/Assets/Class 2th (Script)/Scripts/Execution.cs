using UnityEngine;

public class Execution : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void Start()
    {
        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }
    private void Update()
    {
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
