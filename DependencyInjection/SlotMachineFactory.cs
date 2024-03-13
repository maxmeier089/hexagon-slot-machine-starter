using SlotMachine;

namespace DependencyInjection
{
    public static class SlotMachineFactory
    {

        public static ISlotMachine CreateSlotMachine()
        {
            SlotMachine.SlotMachine slotMachine = new();

            return slotMachine;
        }

    }
}
