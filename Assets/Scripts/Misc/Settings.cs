using UnityEngine;

public static class Settings
{
    // Player Animation Parameters
    public static int xInput;
    public static int yInput;
    public static int isWalking;
    public static int isRunning;
    public static int isIdle;
    public static int isCarrying;
    public static int toolEffect;
    public static int isUsingToolLeft;
    public static int isUsingToolRight;
    public static int isUsingToolUp;
    public static int isUsingToolDown;
    public static int isLiftingToolLeft;
    public static int isLiftingToolRight;
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isPickingLeft;
    public static int isPickingRight;
    public static int isPickingUp;
    public static int isPickingDown;
    public static int isSwingingToolLeft;
    public static int isSwingingToolRight;
    public static int isSwingingToolUp;
    public static int isSwingingToolDown;

    // Shared Animation Parameters
    public static int idleLeft;
    public static int idleRight;
    public static int idleUp;
    public static int idleDown;

    // static contructor
    static Settings()
    {
        xInput = Animator.StringToHash("xInput");
        yInput = Animator.StringToHash("yInput");
        isWalking = Animator.StringToHash("isWalking");
        isRunning = Animator.StringToHash("isRunning");
        isIdle = Animator.StringToHash("isIdle");
        isCarrying = Animator.StringToHash("isCarrying");
        toolEffect = Animator.StringToHash("toolEffect");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolUp = Animator.StringToHash("isUsingToolUp");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isPickingLeft = Animator.StringToHash("isPickingLeft");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingUp = Animator.StringToHash("isPickingUp");
        isPickingDown = Animator.StringToHash("isPickingDown");
        isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
        idleLeft = Animator.StringToHash("idleLeft");
        idleRight = Animator.StringToHash("idleRight");
        idleUp = Animator.StringToHash("idleUp");
        idleDown = Animator.StringToHash("idleDown");
    }
}
