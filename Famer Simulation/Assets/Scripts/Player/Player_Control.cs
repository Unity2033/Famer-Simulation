using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum State
{
    None,
    Building
}

[RequireComponent(typeof(Move))]
[RequireComponent(typeof(Rotation))]
[RequireComponent(typeof(Game))]
public class Player_Control : MonoBehaviour
{
    
    
    
    private Rigidbody rigidbody;
    private Move move;
    private Rotation rotation;
    private Game game;

    public State state;

    public GameObject seed;

    private void Awake()
    {
        move = GetComponent<Move>();
        rotation = GetComponent<Rotation>();
        rigidbody = GetComponent<Rigidbody>();
        game = GetComponent<Game>();
    }

    void Start()
    {
        state = State.None;
    }

    void Update()
    {

        if(state == State.None)
        {
            if (Input.GetKeyDown(KeyCode.B)) { state = State.Building; game.Seeding_AreaCheck(); }
            else if(Input.GetKeyDown(KeyCode.E) && seed)
            {
                Debug.Log("수확 완료!!!");
                seed.GetComponent<AreaControl>().TotalDestory();
            }
        }else if(state == State.Building)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if(game.Seeding() == true)
                {
                    state = State.None;
                }
            }
        }

        move.OnKeyUpdate();
        rotation.OnKeyUpdate();

        
    }

    private void FixedUpdate()
    {
      move.OnMove(rigidbody);
      rotation.RotateY(rigidbody);
    }
}
