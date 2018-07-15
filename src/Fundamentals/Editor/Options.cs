﻿
using Bolt.Addons.Community.Variables.Editor.UnitOptions;
using Ludiq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bolt.Addons.Community.Variables.Editor
{
    [InitializeAfterPlugins]
    public static class Options
    {
        static Options()
        {
            UnitBase.staticUnitsExtensions.Add(GetStaticOptions);
        }

        private static IEnumerable<IUnitOption> GetStaticOptions()
        {
            yield return new IncrementUnitOption(VariableKind.Flow);
            yield return new IncrementUnitOption(VariableKind.Graph);
            yield return new IncrementUnitOption(VariableKind.Object);
            yield return new IncrementUnitOption(VariableKind.Scene);
            yield return new IncrementUnitOption(VariableKind.Application);
            yield return new IncrementUnitOption(VariableKind.Saved);

            yield return new DecrementUnitOption(VariableKind.Flow);
            yield return new DecrementUnitOption(VariableKind.Graph);
            yield return new DecrementUnitOption(VariableKind.Object);
            yield return new DecrementUnitOption(VariableKind.Scene);
            yield return new DecrementUnitOption(VariableKind.Application);
            yield return new DecrementUnitOption(VariableKind.Saved);

            yield return new DecrementUnitOption(VariableKind.Flow);
            yield return new PlusEqualUnitOption(VariableKind.Graph);
            yield return new PlusEqualUnitOption(VariableKind.Object);
            yield return new PlusEqualUnitOption(VariableKind.Scene);
            yield return new PlusEqualUnitOption(VariableKind.Application);
            yield return new PlusEqualUnitOption(VariableKind.Saved);
        }
    }
}
