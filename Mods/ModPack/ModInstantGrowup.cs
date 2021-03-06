﻿using FSLoader;

namespace ModPack
{
    [ModInfo("instant_growup", "Instant child growup", "Robot9706", 1, 0, "Child dwellers grow up instantly.")]
    public class ModInstantGrowup : Mod
    {
        [Hook("DwellerParameters::get_ChildhoodDuration()")]
        public void Hook_ChildhoodDuration(CallContext context)
        {
            context.IsHandled = true;
            context.ReturnValue = 0.01f;

            DwellerParameters param = (DwellerParameters)context.This;
            param.M_childhoodDuration = (float)context.ReturnValue;
        }

        [Hook("DwellerParameters::get_RelationshipBabyBirthTime()")]
        public void Hook_RelationshipBabyBirthTime(CallContext context)
        {
            context.IsHandled = true;
            context.ReturnValue = 0.01f;

            DwellerParameters param = (DwellerParameters)context.This;
            param.M_relationshipBabyBirthTime = (float)context.ReturnValue;
        }
    }
}
