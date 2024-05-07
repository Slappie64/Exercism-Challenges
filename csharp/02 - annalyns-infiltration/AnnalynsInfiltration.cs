using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => (archerIsAwake || knightIsAwake || prisonerIsAwake) ? true : false;


    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => (!archerIsAwake && prisonerIsAwake) ? true : false;


    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
    }
}
