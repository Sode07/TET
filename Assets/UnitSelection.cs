using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    private Transform MovePos;

    public GameObject Selection;
    public GameObject UnitRekry;
    public GameObject EngineerUI;

    private Vector3 center;

    private float radius;
    private float points;
    private float EHP;
    private float DMG;

    private Stats stats;
    public ActionPoints ap;

    public bool SelectingBuilding;

    public LayerMask IgnoreMe;

    public bool isWhiteTurn;

    private void Awake()
    {
        isWhiteTurn = true;
    }

    private void Update()
    {
        points = ap.actionPoints;
        if(points == 0)
        {
            isWhiteTurn = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hiiri alas");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("säde ulos");
                if (hit.transform.tag == "Unit")
                {
                    Selection = hit.transform.gameObject;
                    if(Selection.GetComponent<Stats>().SightRange == 1)
                    {
                        EngineerUI.SetActive(true);
                    }
                    Debug.Log("Yksikkö valittu");
                }
                if (hit.transform.tag == "Base")
                {
                    Selection = null;
                    UnitRekry.SetActive(true);
                }
                else
                {
                    UnitRekry.SetActive(false);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("säde 1 ulos");
                center = Selection.transform.position;
                stats = Selection.transform.gameObject.GetComponent<Stats>();
                Debug.Log(stats);
                Debug.DrawLine(transform.position, hit.point, Color.red);
                if (hit.transform.tag == "Tile")
                {
                    Debug.Log("Osui");
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.MoveRange * 2.3f);
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Selection.transform.position = hit.transform.position;
                            Debug.Log("Yksikkö liikkui");
                            ap.actionPoints -= 1;
                        }
                    }
                }
                if (hit.transform.tag == "Unit")
                {
                    Debug.Log("Osui");
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.AttackRange * 2.3f);
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Debug.Log("Not Crashed!");
                            EHP = hit.transform.gameObject.GetComponent<Stats>().HP;
                            DMG = Selection.transform.gameObject.GetComponent<Stats>().AttackDmg;
                            EHP -= DMG;
                            Debug.Log("Yksikkö Haavoittui");
                            ap.actionPoints -= 1;
                        }
                    }
                }
            }
        }
    }
}